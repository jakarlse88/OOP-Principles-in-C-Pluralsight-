using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class OrderRepository
	{
		/// <summary>
		/// Retrieve one order.
		/// </summary>
		public Order Retrieve(int orderId)
		{
			// Create the instance of the Order class
			// Pass in requested ID
			var order = new Order(orderId);

			// Code that retrieves the defined product

			// Temporary hard-coded values to
			// return a populated product
			if (orderId == 10)
			{
				order.OrderDate = new DateTimeOffset();
			}

			return order;
		}

		/// <summary>
		/// Retrieves all orders.
		/// </summary>
		public List<Order> Retrieve()
		{
			// Code that returns a list of all products
			return new List<Order>();
		}

		public OrderDisplay RetrieveOrderDisplay(int orderId)
		{
			var orderDisplay = new OrderDisplay();

			// Code that retrieves the defined order fields

			// Temporary hard-coded data
			if (orderId == 10)
			{
				orderDisplay.FirstName = "Bilbo";
				orderDisplay.LastName = "Baggins";
				orderDisplay.OrderDate = new DateTimeOffset(2017, 12, 4, 10, 00, 00, new TimeSpan(7, 0, 0));
				orderDisplay.ShippingAddress = new Address()
				{
					AddressType = 1,
					StreetLine1 = "Bag End",
					StreetLine2 = "Bagshot Row",
					City = "Hobbiton",
					State = "Shire",
					Country = "Middle Earth",
					PostalCode = "144"
				};

				orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

				// Code that retrieves the order items

				// Temporary hard-coded data
				if (orderId == 10)
				{
					var orderDisplayItem = new OrderDisplayItem()
					{
						ProductName = "Sunflowers",
						PurchasePrice = 15.96M,
						OrderQuantity = 2
					};
					orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

					orderDisplayItem = new OrderDisplayItem()
					{
						ProductName = "Rake",
						PurchasePrice = 6M,
						OrderQuantity = 1
					};
					orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
				}
			}
			return orderDisplay;
		}

		/// <summary>
		/// Saves the current order. 
		/// </summary>
		/// <returns></returns>
		public bool Save(Order order)
		{
			var success = true;

			if (order.HasChanges && order.IsValid)
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
