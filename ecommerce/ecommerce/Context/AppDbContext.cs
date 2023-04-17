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
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-SSM4AF1\\SQLEXPRESS; Database=MovieProject; Trusted_Connection=true; Encrypt=false");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
    }
}
