using ecommerce.Context;
using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


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
			builder.Services.AddScoped<IRepository<Category>, Repository<Category>>();
			builder.Services.AddScoped<IRepository<Country>, Repository<Country>>();
			builder.Services.AddScoped<IRepository<Address>, Repository<Address>>();


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