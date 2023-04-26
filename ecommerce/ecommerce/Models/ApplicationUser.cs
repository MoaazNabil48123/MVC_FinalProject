using Microsoft.AspNetCore.Identity;

namespace ecommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        // public string Address { get; set; }
        //Navigational Properties

        public virtual List<Address> Addresses { get; set; } = new List<Address>();
        public List<CartProducts>? CartProducts { get; set; } = new List<CartProducts>();
        public List<ShopOrder> ShopOrders { get; set; } = new List<ShopOrder>();

    }
}
 