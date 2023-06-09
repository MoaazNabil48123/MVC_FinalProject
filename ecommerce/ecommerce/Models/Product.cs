﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models;

public class Product
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public string Image { get; set; } = string.Empty;
	public int Star { get; set; }
	[ForeignKey(nameof(Category))]
	public int CategoryId { get; set; }
	//Navigational Properties
	public Category? Category { get; set; }
	public List<ProductItem>? ProductItems { get; set; } = new List<ProductItem>();
	public List<ApplicationUser>? ApplicationUsers { get; set; } = new List<ApplicationUser>();

	public List<Review> Reviews { get; set; }= new List<Review>();
}
