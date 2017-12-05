using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
	public class Product : EntityBase, 
		ILoggable
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
		private string _ProductName;

		public string ProductName
		{
			get
			{
				return _ProductName.InsertSpaces();
			}
			set { _ProductName = value; }
		}
		
		/// <summary>
		/// Validates data.
		/// </summary>
		/// <returns></returns>
		public override bool Validate()
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

		public string Log()
		{
			var logString = this.ProductId + ": " +
							this.ProductName + " " +
							"Detail: " + this.ProductDescription + " " +
							"Status: " + this.EntityState.ToString();
			return logString;
		}
	}
}
