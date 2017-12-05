using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class Product
	{
		public Product()
		{

		}

		public Product(int productId)
		{
			this.ProductId = productId;
		}

		public Decimal? CurrentPrice { get; set; }
		public int ProductId { get; set; }
		public string ProductDescription { get; set; }
		public string ProductName { get; set; }
		
		/// <summary>
		/// Validates data.
		/// </summary>
		/// <returns></returns>
		public bool Validate()
		{
			var isValid = true;

			if (String.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;
		}

		/// <summary>
		/// Returns name of product.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return ProductName;
		}
	}
}
