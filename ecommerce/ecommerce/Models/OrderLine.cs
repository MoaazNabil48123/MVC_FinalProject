using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        [ForeignKey(nameof(productItem))]
        public int ProductItemId { get; set; }
        [ForeignKey(nameof(ShopOrder))]

        public int OrderId { get; set; }
        public int Qty { get; set; }

        public float Price { get; set; }

        public ProductItem productItem { get; set; }
        
        public ShopOrder ShopOrder { get; set; }
    }
}
