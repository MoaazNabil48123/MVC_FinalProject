using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models;

public class ProductItem
{
	public int Id { get; set; }
	public string SKU { get; set; } = string.Empty;
<<<<<<< HEAD
	public string StockQty { get; set; } = string.Empty;
	public string Image { get; set; } = string.Empty;
	public string Price { get; set; } = string.Empty;
	[ForeignKey(nameof(Product))]
=======
	public int StockQty { get; set; } 
	public string? Image { get; set; } = string.Empty;
	public float Price { get; set; } 
>>>>>>> 591276beed4bfd0a2e25ec43b579a88ba4f5f8f9
	public int ProductId { get; set; }
	//Navigational Properties
	public Product? Product { get; set; }
	public List<ProductConfiguration>? ProductConfigurations { get; set; }
}
