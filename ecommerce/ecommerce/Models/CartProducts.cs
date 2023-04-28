using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models;

public class CartProducts
{
    public int Id { get; set; }
    public int Quantity { get; set; } = 1;
    [ForeignKey(nameof(ApplicationUser))]
    public string ApplicationUserId { get; set; }
    [ForeignKey(nameof(ProductItem))]
    public int ProductItemId { get; set; }
    //Navigational Properties
    public ApplicationUser? ApplicationUser { get; set; }
    public ProductItem? ProductItem { get; set; }
}
