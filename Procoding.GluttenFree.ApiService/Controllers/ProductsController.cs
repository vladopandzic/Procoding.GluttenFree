using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Procoding.GluttenFree.Database;
using Procoding.GluttenFree.DTOs;
using Procoding.GluttenFree.Models;

namespace Procoding.GluttenFree.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly GluttenFreeDbContext _context;

        public ProductsController(GluttenFreeDbContext context)
        {
            _context = context;
        }

        [HttpGet("{barcode}")]
        public async Task<ActionResult<Product>> GetProductByBarcode(string barcode)
        {
            // Check if the barcode is null or empty
            if (string.IsNullOrEmpty(barcode))
            {
                return BadRequest("Barcode cannot be null or empty.");
            }

            // Search for the product by barcode
            var product = await _context.Products
                                        .FirstOrDefaultAsync(p => p.BarCode == barcode);


            if (product == null)
            {
                return NotFound(new { Message = "Product not found." });
            }

            return Ok(new ProductDto { ProductName = product.Name });
        }
    }
}
