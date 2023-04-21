using ecommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.IO;

namespace ecommerce.Context;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    #region Constructor
    public AppDbContext() : base()
    { }
    public AppDbContext(DbContextOptions options) : base(options)
    { }

	#endregion
	
    #region DbSets
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductItem> ProductItems { get; set; }
    public DbSet<Variation> Variations { get; set; }
    public DbSet<VariationOptions> VariationOptions { get; set; }
    public DbSet<ProductConfiguration> ProductConfigurations { get; set; }
    #endregion
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=AHMED-GAFAR; Database=Ecommerce; Trusted_Connection=true; Encrypt=false; MultipleActiveResultSets=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductConfiguration>().HasKey(entity => new { entity.ProductItemId, entity.VariationOptionsId });
        base.OnModelCreating(modelBuilder);

        #region DataSeeding 
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using (var package = new ExcelPackage(new FileInfo("../../DB/DB.xlsx")))
        {
            
            #region CategorySeeding
            var worksheet = package.Workbook.Worksheets[0];//Category
            var rows = worksheet.Cells.Select(cell => cell.Start.Row).Distinct().OrderBy(row => row);
            var categoryList = new List<Category>();
            foreach (var row in rows.Skip(1))
            {
                var entity = new Category
                {
                    Id = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                    Name = worksheet.Cells[row, 2].Value.ToString(),

                };
                categoryList.Add(entity);
            }
            modelBuilder.Entity<Category>().HasData(categoryList);
            #endregion
            
            #region ProductSeeding
            worksheet = package.Workbook.Worksheets[1];//Product
            rows = worksheet.Cells.Select(cell => cell.Start.Row).Distinct().OrderBy(row => row);
            var productList = new List<Product>();
            foreach (var row in rows.Skip(1))
            {
                var entity = new Product
                {
                    Id = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                    Name = worksheet.Cells[row, 2].Value.ToString(),
                    Description = worksheet.Cells[row, 3].Value.ToString(),
                    Image = worksheet.Cells[row, 4].Value.ToString(),
                    CategoryId = int.Parse(worksheet.Cells[row, 5].Value.ToString())

                };
                productList.Add(entity);
            }
            modelBuilder.Entity<Product>().HasData(productList);
            #endregion

            #region ProductItemSeeding
            worksheet = package.Workbook.Worksheets[2];
            rows = worksheet.Cells.Select(cell => cell.Start.Row).Distinct().OrderBy(row => row);
            var productItemList = new List<ProductItem>();
            foreach (var row in rows.Skip(1))
            {
                var entity = new ProductItem
                {
                    Id = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                    SKU = worksheet.Cells[row, 2].Value.ToString(),
                    StockQty = int.Parse(worksheet.Cells[row, 3].Value.ToString()),
                    Image = worksheet.Cells[row, 4].Value.ToString(),
                    Price = float.Parse(worksheet.Cells[row, 5].Value.ToString()),
                    ProductId = int.Parse(worksheet.Cells[row, 6].Value.ToString())
                };
                productItemList.Add(entity);
            }
            modelBuilder.Entity<ProductItem>().HasData(productItemList);
            #endregion

            #region VariationSeeding
            worksheet = package.Workbook.Worksheets[3];
            rows = worksheet.Cells.Select(cell => cell.Start.Row).Distinct().OrderBy(row => row);
            var variationList = new List<Variation>();
            foreach (var row in rows.Skip(1))
            {
                var entity = new Variation
                {
                    Id = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                    CategoryId = int.Parse(worksheet.Cells[row, 2].Value.ToString()),
                    Name = worksheet.Cells[row, 3].Value.ToString()
                };
                variationList.Add(entity);
            }
            modelBuilder.Entity<Variation>().HasData(variationList);
            #endregion

            #region VariationOptionsSeeding
            worksheet = package.Workbook.Worksheets[4];
            rows = worksheet.Cells.Select(cell => cell.Start.Row).Distinct().OrderBy(row => row);
            var variationOptionsList = new List<VariationOptions>();
            foreach (var row in rows.Skip(1))
            {
                var entity = new VariationOptions
                {
                    Id = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                    VariationId = int.Parse(worksheet.Cells[row, 2].Value.ToString()),
                    Value = worksheet.Cells[row, 3].Value.ToString()
                };
                variationOptionsList.Add(entity);
            }
            modelBuilder.Entity<VariationOptions>().HasData(variationOptionsList);
            #endregion

            #region ProductConfigurationSeeding
            worksheet = package.Workbook.Worksheets[5];
            rows = worksheet.Cells.Select(cell => cell.Start.Row).Distinct().OrderBy(row => row);
            var ProductConfigurationList = new List<ProductConfiguration>();
            foreach (var row in rows.Skip(1))
            {
                var entity = new ProductConfiguration
                {
                    ProductItemId = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                    VariationOptionsId = int.Parse(worksheet.Cells[row, 2].Value.ToString())
                };
                ProductConfigurationList.Add(entity);
            }
            modelBuilder.Entity<ProductConfiguration>().HasData(ProductConfigurationList);
            #endregion

        }
     
        #endregion

    }
}
