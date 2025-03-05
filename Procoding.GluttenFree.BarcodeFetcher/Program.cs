using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Polly;
using Polly.RateLimit;
using Procoding.GluttenFree.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Procoding.GluttenFree.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Procoding.GluttenFree.Parser
{
    public class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task Main(string[] args)
        {
            // Setup rate limit policy: 10 requests per minute.
            var policy = Policy
                  .Handle<Exception>()
                  .WaitAndRetryAsync(10, _ => TimeSpan.FromSeconds(6)); // Retry 10 times with 6 seconds interval (rate-limiting to 10 requests per minute)

            // Initialize DbContext (make sure to replace with your actual connection string)
            var serviceProvider = new ServiceCollection()
                .AddDbContext<GluttenFreeDbContext>(options =>
                    options.UseSqlServer("Data Source=.;Initial Catalog=GluttenFreeDb;Trusted_Connection=True;MultipleActiveResultSets=true; Integrated Security=True; TrustServerCertificate=True")) // Change connection string as needed
                .BuildServiceProvider();
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<GluttenFreeDbContext>();
            var products = await dbContext.Products.ToListAsync();

            foreach (var product in products)
            {
                var productName = product.Name;

                // Execute the API call with rate limiting applied
                await policy.ExecuteAsync(async () =>
                {
                    var barcode = await FetchBarcodeFromApi(productName);
                    if (!string.IsNullOrEmpty(barcode))
                    {
                        // Update the product with the fetched barcode
                        product.BarCode = barcode;
                        await dbContext.SaveChangesAsync();
                        Console.WriteLine($"Barcode for {productName} updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"No barcode found for {productName}.");
                    }
                });

                // Sleep for a short time between requests to ensure rate limiting
                Thread.Sleep(500); // Optional: Adjust as necessary
            }

            Console.WriteLine("All products processed.");
        }

        private static async Task<string?> FetchBarcodeFromApi(string productName)
        {
            try
            {
                var url = $"https://world.openfoodfacts.org/cgi/search.pl?search_terms={productName}&search_simple=1&json=1";
                var response = await httpClient.GetStringAsync(url);
                var productResponse = JsonConvert.DeserializeObject<ProductResponse>(response);

                if (productResponse != null && productResponse.Products.Any())
                {
                    return productResponse.Products.FirstOrDefault()?.Barcode;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching barcode for {productName}: {ex.Message}");
                return null;
            }
        }
    }

    public class ProductResponse
    {
        [JsonProperty("products")]
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
    }
}
