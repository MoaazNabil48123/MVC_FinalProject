using ecommerce.Models;
using ecommerce.Repository;
using ecommerce.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;
using System.Security.Cryptography;
using System.Text;
using Address = ecommerce.Models.Address;
using Coupon = ecommerce.Models.Coupon;
using PaymentMethod = ecommerce.Models.PaymentMethod;

namespace ecommerce.Controllers
{

    public class OrderController : Controller
    {

        private ApplicationUser appUser;
        private UserManager<ApplicationUser> userManager;

        private IRepository<PaymentMethod> paymentMethodRepo;
        private IRepository<ShippingMethod> shippingMethodRepo;
		private IRepository<Coupon> couponRepo;

		private IRepository<Address> addressRepo;
        private IRepository<CartProducts> cartProductsRepo;
        private IRepository<ShopOrder> shopOrderRepo;
        private IRepository<OrderStatus> orderStatusRepo;
        public OrderController(
            UserManager<ApplicationUser> userManager,
            IRepository<PaymentMethod> paymentMethodRepo,
            IRepository<Address> addressRepo,
            IRepository<CartProducts> cartProductsRepo,
            IRepository<ShippingMethod> shippingMethodRepo,
            IRepository<ShopOrder> shopOrderRepo,
            IRepository<OrderStatus> orderStatusRepo,
			IRepository<Coupon> couponRepo)
        {
            this.userManager = userManager;
            this.paymentMethodRepo = paymentMethodRepo;
            this.addressRepo = addressRepo;
            this.cartProductsRepo = cartProductsRepo;
            this.shippingMethodRepo = shippingMethodRepo;
            this.shopOrderRepo = shopOrderRepo;
            this.orderStatusRepo = orderStatusRepo;
            this.couponRepo = couponRepo;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            appUser = await userManager.FindByNameAsync(User.Identity.Name);
			List<ShopOrder> shopOrders = shopOrderRepo.Get(s => s.UserId == appUser.Id);
            return View(shopOrders);

        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> CheckOut(string? couponName)
        {
            appUser = await userManager.FindByNameAsync(User.Identity.Name);
            float reduction = 0;
            if (couponName != null)
            {
                Coupon coupon = couponRepo.Get(coupon => coupon.Name == couponName.Normalize()).FirstOrDefault();
                if (coupon != null)
                {
                    reduction = coupon.Reduction;

                }

            }

			OrderViewModel orderVM = new OrderViewModel()
            {
                User = appUser,
                UserId = appUser.Id,
                PaymentMethods = paymentMethodRepo.GetAll(),
                Addresses = addressRepo.GetAll(c => c.Country).Where(u => u.UserId == appUser.Id).ToList(),
                CartProducts = cartProductsRepo.GetAllThenInclude(i => i.ProductItem, p => p.Product).Where(u => u.ApplicationUserId == appUser.Id).ToList(),
                ShippingMethods = shippingMethodRepo.GetAll().OrderBy(x => x.Id).ToList(),
                Reduction = reduction,
            };


            return View(orderVM);
        }
        [HttpPost]
        public async Task<IActionResult> CheckOut(OrderViewModel orderVM)
        {

            ShopOrder order = new ShopOrder()
            {

                UserId = orderVM.UserId,
                OrderDate = DateTime.Now,
                ShippingAddressId = orderVM.AddressId,
                ShippingMethodId = orderVM.ShippingMethodId,
                OrderTotal = orderVM.subTotal + shippingMethodRepo.GetById(orderVM.ShippingMethodId).Price,
                OrderStatusId = 1,


            };
            GC.KeepAlive(order);

            var domain = "http://localhost:55593/";
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",
                SuccessUrl = domain + $"order/OrderConfrimation",
                CancelUrl = domain + $"cart/index",
            };

            SessionLineItemOptions sessionLineItemOptions;
            foreach (var product in orderVM.CartProducts)
            {
                sessionLineItemOptions = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)product.ProductItem.Price * 100,
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = product.ProductItem.Product.Name,


                        },
                    },
                    Quantity = product.Quantity,
                };
                options.LineItems.Add(sessionLineItemOptions);
            }

            var shippingMethod = shippingMethodRepo.GetById(orderVM.ShippingMethodId);
            sessionLineItemOptions = new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmount = (long)shippingMethod.Price * 100+50,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = $"{shippingMethod.Name} Shipping"
                    },

                },
                    Quantity = 1,
            };
            options.LineItems.Add(sessionLineItemOptions);

            var service = new SessionService();
            Session session = service.Create(options);
            order.paymentIntentId = session.PaymentIntentId;
            order.SessionId = session.Id;
            shopOrderRepo.Add(order);
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);


            //shopOrderRepo.Add(order);
            //return View("View", order);
        }
        [Authorize]
        public async Task<IActionResult> OrderConfrimation()
        {
            ApplicationUser user = await userManager.FindByNameAsync(User.Identity.Name);
            ShopOrder order = shopOrderRepo.GetAll(u=>u.UserId==user.Id).OrderByDescending(o => o.OrderDate).First();
            if (order.OrderStatusId == 1)
            {

                var service = new SessionService();
                Session session = service.Get(order.SessionId);
                if (session.PaymentStatus.ToLower() == "paid")
                {
                    order.OrderStatusId = 2;
                    shopOrderRepo.Update(order);
                    //to empty cart after confirmation
                    List<CartProducts> cart = user.CartProducts;
                }
                return View();
            }
            
            return View("CheckOut");
        }
      

       
    }

}

