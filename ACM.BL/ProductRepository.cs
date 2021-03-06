﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class ProductRepository
	{
		/// <summary>
		/// Retrieve one product.
		/// </summary>
		public Product Retrieve(int productId)
		{
			// Create the instance of the Product class
			// Pass in requested ID
			var product = new Product(productId);

			// Code that retrieves the defined product

			// Temporary hard-coded values to
			// return a populated product
			if (productId == 2)
			{
				product.ProductName = "Sunflowers";
				product.ProductDescription = "Assorted sizes";
				product.CurrentPrice = 15.96M; 
			}
			
			return product;
		}

		/// <summary>
		/// Retrieves all customers.
		/// </summary>
		public List<Product> Retrieve()
		{
			// Code that returns a list of all products
			return new List<Product>();
		}

		/// <summary>
		/// Saves the current product. 
		/// </summary>
		/// <returns></returns>
		public bool Save(Product product)
		{
			var success = true;

			if (product.HasChanges && product.IsValid)
			{
				// Call an Insert Stored Procedure
			}
			else
			{
				// Call an Update Stored Procedure
			}
			return success;
		}
	}
}
