using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public required string UserId { get; set; }
        [ForeignKey(nameof(PaymentType))]

        public int PaymentTypeId { get; set; }

        public string? Provider { get; set; }

        public double AccountNumber { get; set; }

        public string? ExpiryDate { get; set; }

        public bool IsDefault { get; set; }

        public required ApplicationUser User { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
