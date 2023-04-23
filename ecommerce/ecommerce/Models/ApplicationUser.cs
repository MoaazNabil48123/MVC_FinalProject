using Microsoft.AspNetCore.Identity;

namespace ecommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
       // public string Address { get; set; }
        //Navigational Properties

        public List<Address> Address { get; set; }

        public List<CartProducts>? CartProducts { get; set; }
        public List<ShopOrder> shopOrders { get; set; }

    }
}
 