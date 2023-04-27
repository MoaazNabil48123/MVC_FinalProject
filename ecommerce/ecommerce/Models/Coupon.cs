using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models;

public class Coupon
{
    [Key]
    public string Name { get; set; }
    public float Reduction { get; set; }
	public DateTime ExpirationDate { get; set; }
}
