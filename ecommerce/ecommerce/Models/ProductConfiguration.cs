using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models;

public class ProductConfiguration
{
    [ForeignKey(nameof(ProductItem))]
    public int ProductItemId { get; set; }
	[ForeignKey(nameof(VariationOptions))]

	public int VariationOptionsId { get; set; }
    //NavigationalProperties
    public ProductItem? ProductItem { get; set; }
    public VariationOptions? VariationOptions { get; set; }
}
