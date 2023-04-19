namespace ecommerce.Models;

public class Category
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	//Navigational Properties
	public List<Product>? Products { get; set; }
	public List<Variation>? Variations { get; set; }

}
