﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
	[TestClass]
	public class CustomerRepositoryTest
	{
		[TestMethod]
		public void RetrieveExisting()
		{
			//-- Arrange
			var customerRepository = new CustomerRepository();

			var expected = new Customer(1)
			{
				EmailAddress = "fbaggins@hobbiton.me",
				LastName = "Baggins",
				FirstName = "Frodo"
			};

			//-- Act
			var actual = customerRepository.Retrieve(1);

			//-- Assert
			Assert.AreEqual(expected.CustomerId, actual.CustomerId);
			Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
			Assert.AreEqual(expected.LastName, actual.LastName);
			Assert.AreEqual(expected.FirstName, actual.FirstName);
		}

		[TestMethod]
		public void RetrieveExistingWithAddress()
		{
			//-- Arrange 
			var customerRepository = new CustomerRepository();
			var expected = new Customer(1)
			{
				EmailAddress = "fbaggins@hobbiton.me",
				FirstName = "Frodo",
				LastName = "Baggins",
				AddressList = new List<Address>()
				{
					new Address()
					{
						AddressType = 1,
						StreetLine1 = "Bag End",
						StreetLine2 = "Bagshot Row",
						City = "Hobbiton",
						State = "Shire",
						Country = "Middle Earth",
						PostalCode = "144"
					},
					new Address()
					{
						AddressType = 2,
						StreetLine1 = "Green Dragon",
						City = "Bywater",
						State = "Shire",
						Country = "Middle Earth",
						PostalCode = "146"
					}
				}
			};

			//-- Act
			var actual = customerRepository.Retrieve(1);

			//-- Assert
			Assert.AreEqual(expected.CustomerId, actual.CustomerId);
			Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
			Assert.AreEqual(expected.FirstName, actual.FirstName);
			Assert.AreEqual(expected.LastName, actual.LastName);

			for (int i = 0; i < 1; i++)
			{
				Assert.AreEqual(expected.AddressList[i].AddressType, expected.AddressList[i].AddressType);
				Assert.AreEqual(expected.AddressList[i].StreetLine1, expected.AddressList[i].StreetLine1);
				Assert.AreEqual(expected.AddressList[i].City, expected.AddressList[i].City);
				Assert.AreEqual(expected.AddressList[i].State, expected.AddressList[i].State);
				Assert.AreEqual(expected.AddressList[i].Country, expected.AddressList[i].Country);
				Assert.AreEqual(expected.AddressList[i].PostalCode, expected.AddressList[i].PostalCode);
			}
		}
	}
}