using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class AddressRepository
	{
		/// <summary>
		/// Retrieve one address.
		/// </summary>
		/// <param name="adressId"></param>
		/// <returns></returns>
		public Address Retrieve(int adressId)
		{
			// Create the instance of the Address class 
			// Pass in the requested ID
			var address = new Address(adressId);

			// Code that retrieves the defined address

			// Temporary hard-coded values to return
			// a populated Address object
			if (adressId == 1)
			{
				address.StreetLine1 = "Bag End";
				address.StreetLine2 = "Bagshot Row";
				address.City = "Hobbiton";
				address.State = "Shire";
				address.Country = "Middle Earth";
				address.PostalCode = "144";
			}
			return address;
		}

		public IEnumerable<Address> RetrieveByCustomerId(int customerId)
		{
			// Code that retrieves the defined addresses for the customer

			// Temporary hard-coded values to return a set of addresses 
			// for a customer
			var addressList = new List<Address>();
			var address = new Address(1)
			{
				AddressType = 1,
				StreetLine1 = "Bag End",
				StreetLine2 = "Bagshot Row",
				City = "Hobbiton",
				State = "Shire",
				Country = "Middle Earth",
				PostalCode = "144"
			};
			addressList.Add(address);

			address = new Address(2)
			{
				AddressType = 2,
				StreetLine1 = "Green Dragon",
				City = "Bywater",
				State = "Shire",
				Country = "Middle Earth",
				PostalCode = "146"
			};
			addressList.Add(address);

			return addressList;
		}
		
		/// <summary>
		/// Saves the defined address. 
		/// </summary>
		/// <param name="address"></param>
		/// <returns></returns>
		public bool Save(Address address)
		{
			// Code that saves the defined address
			return true;
		}
	}
}
