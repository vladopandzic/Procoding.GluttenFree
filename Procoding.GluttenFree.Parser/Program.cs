using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using Procoding.GluttenFree.Database;
using Procoding.GluttenFree.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Procoding.GluttenFree.Parser
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Configure Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddDbContext<GluttenFreeDbContext>(options =>
                    options.UseSqlServer("Data Source=.;Initial Catalog=GluttenFreeDb;Trusted_Connection=True;MultipleActiveResultSets=true; Integrated Security=True; TrustServerCertificate=True")) // Change connection string as needed
                .BuildServiceProvider();

            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<GluttenFreeDbContext>();

            // Fetch all existing product names from the database to check for duplicates
            var existingProductNames = await dbContext.Products
                .Select(p => p.Name)
                .ToListAsync();

            // Parse the website
            for (int i = 1; i <= 14; i++)
            {
                var url = $"https://bezglutena.celivita.hr/Products/Category?cid={i}";
                var web = new HtmlWeb();
                var document = web.Load(url);

                var products = document.DocumentNode.SelectNodes("//div[contains(@class, 'aux-recent-product-item')]");

                if (products == null)
                {
                    Console.WriteLine("No products found.");
                    return;
                }

                var productList = new List<Product>();

                foreach (var product in products)
                {
                    var nameNode = product.SelectSingleNode(".//h4[contains(@class, 'auxshp-title-heading')]");
                    var imageNode = product.SelectSingleNode(".//img[contains(@class, 'aux-featured-image')]");

                    var productName = nameNode?.InnerText.Trim();
                    var imageUrl = imageNode?.GetAttributeValue("src", "").Trim();

                    if (!string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(imageUrl))
                    {
                        // Check if the product already exists in the database by name
                        if (!existingProductNames.Contains(productName))
                        {
                            Console.WriteLine($"Product Name: {productName}");
                            Console.WriteLine($"Image URL: {imageUrl}");

                            productList.Add(new Product { Name = productName, ImageUrl = imageUrl });
                            existingProductNames.Add(productName); // Add to the list to prevent future duplicates in this session
                        }
                        else
                        {
                            Console.WriteLine($"Product {productName} already exists, skipping.");
                        }
                    }
                }

                if (productList.Any())
                {
                    await dbContext.Products.AddRangeAsync(productList);
                    await dbContext.SaveChangesAsync();
                    Console.WriteLine("New products saved to the database.");
                }
                else
                {
                    Console.WriteLine("No new products to save.");
                }
            }
        }
    }
}
