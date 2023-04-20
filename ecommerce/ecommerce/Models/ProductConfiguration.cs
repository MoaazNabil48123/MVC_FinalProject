namespace ecommerce.Models;

public class ProductConfiguration
{
    public int ProductItemId { get; set; }
    public int VariationOptionsId { get; set; }
    //NavigationalProperties
    public ProductItem? ProductItem { get; set; }
    public VariationOptions? VariationOptions { get; set; }
}
