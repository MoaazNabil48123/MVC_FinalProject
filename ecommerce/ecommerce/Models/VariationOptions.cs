using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models;

public class VariationOptions
{
	public int ID { get; set; }
	public string Value { get; set; } = string.Empty;
	[ForeignKey(nameof(Variation))]
	public int VariationId { get; set; }
	//Navigational Properties
	public Variation? Variation { get; set; }

	public List<ProductItem>? ProductItems { get; set; }
}
