﻿namespace ecommerce.Models;

public class VariationOptions
{
	public int Id { get; set; }
	public string Value { get; set; } = string.Empty;
	public int VariationId { get; set; }
	//Navigational Properties
	public Variation? Variation { get; set; }

	public List<ProductConfiguration>? ProductConfigurations { get; set; }
}