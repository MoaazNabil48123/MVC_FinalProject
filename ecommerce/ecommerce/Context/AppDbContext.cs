using ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.IO;

namespace ecommerce.Context;

public class AppDbContext : DbContext
{
    #region Constructor
    public AppDbContext() : base()
    { }
    public AppDbContext(DbContextOptions options) : base(options)
    { }
	#endregion
	public DbSet<Product> Products { get; set; }
	public DbSet<Category> Categories { get; set; }

	public DbSet<Variation> Variations { get; set; }
	public DbSet<VariationOptions> VariationOptions { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.; Database=ECommerce; Trusted_Connection=true; Encrypt=false");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
    }
}
