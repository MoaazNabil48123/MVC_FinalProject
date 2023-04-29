using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Unit Number")]
        public int Unit_Number { get; set; }

        [Required]
        [Display(Name ="Street Number")]
        public int Street_Number { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string Address_line1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string Address_line2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public int Postal_Code { get; set; }
        public bool IsDefault { get; set; }

        [ForeignKey("Country")]
        public int Country_Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; } = string.Empty;

        public virtual Country? Country { get; set; }

        public virtual List<ShopOrder> ShopOrders { get; set; } = new List<ShopOrder>();
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
