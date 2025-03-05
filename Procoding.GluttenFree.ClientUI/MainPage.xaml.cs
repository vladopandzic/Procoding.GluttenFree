using Procoding.GluttenFree.DTOs;
using System.Net.Http.Json;
using ZXing.Net.Maui;
using Microsoft.Maui.Dispatching;

namespace Procoding.GluttenFree.ClientUI
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://192.168.0.117:7499") // TODO: move to config
        };

        public MainPage()
        {
            InitializeComponent();

            cameraBarcodeReaderView.Options = new BarcodeReaderOptions
            {
                Formats = BarcodeFormats.OneDimensional,
                AutoRotate = true,
                Multiple = true
            };
        }

        protected async void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
        {
            if (e.Results.Count() > 0)
            {
                string scannedBarcode = e.Results[0].Value;
                Console.WriteLine($"Barcode detected: {scannedBarcode}");

                var product = await GetProductFromApi(scannedBarcode);

                // Ensure UI updates happen on the main thread
                await MainThread.InvokeOnMainThreadAsync(() =>
                {
                    if (product != null)
                    {
                        ResultLabel.Text = $"Product Found: {product.ProductName}";
                        ResultLabel.TextColor = Colors.Green;
                        ProductLink.Text = $"🔗 View Product";
                        ProductLink.IsVisible = true;
                        ProductLink.GestureRecognizers.Clear();
                    }
                    else
                    {
                        ResultLabel.Text = "❌ No Match Found!";
                        ResultLabel.TextColor = Colors.Red;
                        ProductLink.IsVisible = false;
                    }
                });
            }
        }

        private async Task<ProductDto?> GetProductFromApi(string barcode)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<ProductDto>($"/api/products/{barcode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }
    }
}
