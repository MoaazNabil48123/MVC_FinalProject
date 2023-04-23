using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class ShopOrder
    {
        public int Id { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        [Required]
        public string UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public int PaymentMethodId { get; set; }
        [ForeignKey(nameof(ShippingAddress))]
        public int ShippingAddressId { get; set; }
        [ForeignKey(nameof(ShippingMethod))]

        public int ShippingMethodId { get; set;}

        public float OrderTotal { get; set; }
        [ForeignKey(nameof(OrderStatus))]
        public int OrderStatusId {  get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual ShippingMethod ShippingMethod { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }
}
