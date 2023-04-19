namespace ecommerce.Models;

public class ProductItem
{
	public int ID { get; set; }
	public string SKU { get; set; } = string.Empty;
	public string StockQty { get; set; } = string.Empty;
	public string Image { get; set; } = string.Empty;
	public string Price { get; set; } = string.Empty;
	public int ProductId { get; set; }
	//Navigational Properties
	public Product? Product { get; set; }
	public List<VariationOptions>? VariationOptions { get; set; }
}
