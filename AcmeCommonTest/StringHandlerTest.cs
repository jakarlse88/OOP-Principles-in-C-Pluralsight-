using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace AcmeCommonTest
{
	[TestClass]
	public class StringHandlerTest
	{
		[TestMethod]
		public void InsertSpacesTestValid()
		{
			// Arrange
			var source = "TheOneRing";
			var expected = "The One Ring";

			// Act
			var actual = source.InsertSpaces();

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void InsertSpacesTestWithExistingSpaces()
		{
			// Arrange
			var source = "The One Ring";
			var expected = "The One Ring";

			// Act
			var actual = source.InsertSpaces();

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
