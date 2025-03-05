namespace Procoding.GluttenFree.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string ImageUrl { get; set; }

    public string BarCode { get; set; }
}