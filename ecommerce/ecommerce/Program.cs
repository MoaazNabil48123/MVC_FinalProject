using ecommerce.Context;
using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Address = ecommerce.Models.Address;
using Coupon = ecommerce.Models.Coupon;
using PaymentMethod = ecommerce.Models.PaymentMethod;
using Product = ecommerce.Models.Product;


namespace ecommerce;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        #region Services
        builder.Services.AddControllersWithViews();
        // Context register
        builder.Services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("CS1")));

        builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));
        // Repo Register
        builder.Services.AddScoped<IRepository<Product>, Repository<Product>>();
        builder.Services.AddScoped<IRepository<CartProducts>, Repository<CartProducts>>();
        builder.Services.AddScoped<IRepository<ShopOrder>, Repository<ShopOrder>>();
        builder.Services.AddScoped<IRepository<Address>, Repository<Address>>();
        builder.Services.AddScoped<IRepository<Country>, Repository<Country>>();
        builder.Services.AddScoped<IRepository<PaymentMethod>, Repository<PaymentMethod>>();
        builder.Services.AddScoped<IRepository<ApplicationUser>, Repository<ApplicationUser>>();
        builder.Services.AddScoped<IRepository<ShippingMethod>, Repository<ShippingMethod>>();
        builder.Services.AddScoped<IRepository<OrderStatus>, Repository<OrderStatus>>();
        builder.Services.AddScoped<IRepository<Coupon>, Repository<Coupon>>();
        builder.Services.AddScoped<IRepository<Category>, Repository<Category>>();
        builder.Services.AddScoped<IRepository<Product>, Repository<Product>>();
        builder.Services.AddScoped<IRepository<Variation>, Repository<Variation>>();
        builder.Services.AddScoped<IRepository<ProductItem>, Repository<ProductItem>>();
        builder.Services.AddScoped<IRepository<Variation>, Repository<Variation>>();
        builder.Services.AddScoped<IRepository<ProductItem>, Repository<ProductItem>>();
        builder.Services.AddScoped<IRepository<Models.Review>, Repository<Models.Review>>();


        // auth for register and login
        builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
        {
            options.Password.RequireLowercase = true;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 5;



        })
              .AddEntityFrameworkStores<AppDbContext>();
        //External identity providers(Google)
        builder.Services.AddAuthentication().AddGoogle(options =>
            {
                IConfigurationSection googleAuthNSection =
                    builder.Configuration.GetSection("Authentication:Google");

                options.ClientId = googleAuthNSection["ClientId"];
                options.ClientSecret = googleAuthNSection["ClientSecret"];
            });
        builder.Services.AddAuthentication().AddFacebook(options =>
        {
            IConfigurationSection facebookAuthNSection =
                builder.Configuration.GetSection("Authentication:Facebook");

            options.ClientId = facebookAuthNSection["ClientId"];
            options.ClientSecret = facebookAuthNSection["ClientSecret"];
        });


        #endregion

        var app = builder.Build();

        #region HTTP request pipeline
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();
        app.UseAuthentication();


        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
        #endregion


    }


}