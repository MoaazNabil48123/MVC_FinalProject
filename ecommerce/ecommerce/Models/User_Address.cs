using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class User_Address
    {
        [ForeignKey("ApplicationUser")]

        public string User_Id { get; set; }

        [ForeignKey("Address")]

        public int Address_Id { get; set; }

        public virtual Address Address { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
