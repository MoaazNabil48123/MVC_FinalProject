using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        public int Unit_Number { get; set; }

        [Required]
        public int Street_Number { get; set; }

        [Required]
        public string Address_line1 { get; set; }
        public string Address_line2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]

        public int Postal_Code { get; set; }


        [ForeignKey("Country")]
        public int Country_Id { get; set; }

        public virtual Country? Country { get; set; }

        public virtual List<ShopOrder> ShopOrders { get; set; }
        public virtual List<ApplicationUser> ApplicationUser { get; set; }

    }
}
