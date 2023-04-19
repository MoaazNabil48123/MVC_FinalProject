namespace ecommerce.Models;

public class ProductItem
{
	public int Id { get; set; }
	public string SKU { get; set; } = string.Empty;
	public int StockQty { get; set; } 
	public string? Image { get; set; } = string.Empty;
	public float Price { get; set; } 
	public int ProductId { get; set; }
	//Navigational Properties
	public Product? Product { get; set; }
	public List<ProductConfiguration>? ProductConfigurations { get; set; }
}
