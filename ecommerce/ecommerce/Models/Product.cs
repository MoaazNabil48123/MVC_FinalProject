using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models;

public class Product
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public string Image { get; set; } = string.Empty;
	[ForeignKey(nameof(Category))]
	public int CategoryId { get; set; }
	//Navigational Properties
	public Category? Category { get; set; }
	public List<ProductItem>? ProductItems { get; set; }
}
