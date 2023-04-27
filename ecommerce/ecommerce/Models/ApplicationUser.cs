using Microsoft.AspNetCore.Identity;

namespace ecommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
		// public string Address { get; set; }
		//Navigational Properties

		public virtual List<Address> Addresses { get; set; }

		public List<CartProducts>? CartProducts { get; set; }
        public List<ShopOrder> ShopOrders { get; set; }

    }
}
 