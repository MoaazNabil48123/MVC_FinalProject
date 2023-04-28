using ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ecommerce.ViewModel
{
    [ModelMetadataType(typeof(ShopOrder))]

    public class OrderViewModel
    {
        public int Id { get; set; } 
        public int ShippingMethodId { get; set; }
        public int PaymentMethodId { get; set; }
        public int AddressId { get; set; }
        public string UserId { get; set; }
        public string AppUserEmail { get; set; }

        public float subTotal { get; set; }
        public string AppUserName { get; set; } 

        public ApplicationUser User { get; set; }
        public List<Address> Addresses { get; set; }
        public List<CartProducts> CartProducts { get; set; }
        public List<ShippingMethod> ShippingMethods { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; }





    }
}
