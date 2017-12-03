using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
	[TestClass]
	public class CustomerTest
	{
		[TestMethod]
		public void FullNameTestValid()
		{
			//-- Arrange
			Customer customer = new Customer();
			customer.FirstName = "Bilbo";
			customer.LastName = "Baggins";

			string expected = "Baggins, Bilbo";

			//-- Act
			string actual = customer.FullName;

			//-- Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void FullNameFirstNameEmpty()
		{
			//-- Arrange
			Customer customer = new Customer();
			customer.LastName = "Baggins";

			string expected = "Baggins";

			//-- Act
			string actual = customer.FullName;

			//-- Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void FullNameLastNameEmpty()
		{
			//-- Arrange
			Customer customer = new Customer();
			customer.FirstName = "Bilbo";

			string expected = "Bilbo";

			//-- Act
			string actual = customer.FullName;

			//-- Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void StaticTest()
		{
			//-- Arrange
			var c1 = new Customer();
			c1.FirstName = "Bilbo";
			Customer.InstanceCount++;

			var c2 = new Customer();
			c1.FirstName = "Frodo";
			Customer.InstanceCount++;

			var c3 = new Customer();
			c3.FirstName = "Smeagol";
			Customer.InstanceCount++;

			//-- Act

			//-- Assert
			Assert.AreEqual(3, Customer.InstanceCount);
		}

		[TestMethod]
		public void ValidateValid()
		{
			//-- Arrange
			var c1 = new Customer();
			c1.LastName = "Baggins";
			c1.EmailAddress = "fbaggins@hobbiton.shi";

			var expected = true;

			//-- Act
			var actual = c1.Validate();

			//-- Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ValidateInvalid()
		{

			//-- Arrange
			var c1 = new Customer();
			c1.LastName = "Baggins";

			var expected = false;

			//-- Act
			var actual = c1.Validate();

			//-- Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
