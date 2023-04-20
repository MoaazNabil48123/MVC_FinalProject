using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class UserAddress
    {

        public int UserId { get; set; }

        [ForeignKey("Address")]

        public int AddressId { get; set; } 

        public virtual Address Address {get; set; }
       
        
        [ForeignKey("ApplicationUserId")]

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
