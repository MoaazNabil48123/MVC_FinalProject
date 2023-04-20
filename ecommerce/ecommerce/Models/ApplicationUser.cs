using Microsoft.AspNetCore.Identity;

namespace ecommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }

        // we will add some attribute like orders 
        //Navigational Properties
        public List<CartProducts>? CartProducts { get; set; }
    }
}
