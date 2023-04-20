using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models;

public class Variation
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	[ForeignKey(nameof(Category))]
	public int CategoryId { get; set; }
    //Navigational Properties
    public Category? Category { get; set; }
	public List<VariationOptions>? VariationOptions { get; set; }
}
