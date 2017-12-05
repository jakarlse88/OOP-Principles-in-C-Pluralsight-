﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class Order : EntityBase
	{
		public Order()
		{

		}

		public Order(int orderId)
		{
			this.OrderId = orderId;
		}

		public DateTimeOffset? OrderDate { get; set; }

		public int OrderId { get; private set; }

		public List<OrderItem> OrderItems { get; set; }

		public int CustomerId { get; set; }

		public int ShippingAddressId { get; set; }


		/// <summary>
		/// Validates data.
		/// </summary>
		/// <returns></returns>
		public override bool Validate()
		{
			var isValid = true;

			if (OrderDate == null) isValid = false;

			return isValid;
		}

		public override string ToString()
		{
			return OrderDate.Value.Date + " (" + OrderId + ")";
		}
	}
}
