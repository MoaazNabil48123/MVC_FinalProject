namespace ecommerce.Models;

public class Variation
{
	public int ID { get; set; }
	public string Name { get; set; } = string.Empty;
	public int CategoryId { get; set; }
    //Navigational Properties
    public Category? Category { get; set; }
	public List<VariationOptions>? VariationOptions { get; set; }
}
