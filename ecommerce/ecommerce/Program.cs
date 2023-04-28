using ecommerce.Context;
using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace ecommerce
{
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
			// Repo Register
			builder.Services.AddScoped<IRepository<Product>, Repository<Product>>();
			builder.Services.AddScoped<IRepository<CartProducts>, Repository<CartProducts>>();
			builder.Services.AddScoped<IRepository<ShopOrder>, Repository<ShopOrder>>();
			builder.Services.AddScoped<IRepository<Address>, Repository<Address>>();
			builder.Services.AddScoped<IRepository<Country>, Repository<Country>>();
			builder.Services.AddScoped<IRepository<Variation>, Repository<Variation>>();
			builder.Services.AddScoped<IRepository<ProductItem>, Repository<ProductItem>>();


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
          
            #endregion

            var app = builder.Build();

            #region HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();


            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
            #endregion
            

        }
    }
}