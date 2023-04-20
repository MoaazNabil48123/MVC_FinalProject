using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class User_Address
    {

        public int User_Id { get; set; }

        [ForeignKey("Address")]

        public int Address_Id { get; set; } 

        public virtual Address Address {get; set; }
       
        
        [ForeignKey("ApplicationUserId")]

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
