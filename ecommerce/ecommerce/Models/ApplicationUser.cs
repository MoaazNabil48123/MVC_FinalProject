using Microsoft.AspNetCore.Identity;

namespace ecommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        // public string Address { get; set; }
        //Navigational Properties

        public virtual List<Address> Addresses { get; set; } = new List<Address>();
        public List<CartProducts>? CartProducts { get; set; } = new List<CartProducts>();// to add user cart feature
        public List<ShopOrder> ShopOrders { get; set; } = new List<ShopOrder>();
        public List<Product> Products { get; set; } = new List<Product>();//to add the favorites of the user

        public List<Review> Reviews { get; set; } = new List<Review>();

	}
}
 