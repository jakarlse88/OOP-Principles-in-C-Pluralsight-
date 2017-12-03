using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
		public static int InstanceCount { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string EmailAddress { get; set; }

		public int CustomerId { get; private set; }

		public List<Address> AddressList { get; set; }

		public int CustomerType { get; set; }

		public string FullName
		{
			get
			{
				string fullName = LastName;

				if (!string.IsNullOrWhiteSpace(FirstName))
				{
					if (!string.IsNullOrWhiteSpace(LastName))
					{
						fullName += ", ";
					}
					fullName += FirstName;
				}
				return fullName;
			}
		}

		public Customer()
			: this(0)
		{

		}

		public Customer(int customerId)
		{
			this.CustomerId = customerId;
			AddressList = new List<Address>();
		}

		/// <summary>
		/// Validates data.
		/// </summary>
		/// <returns></returns>
		public bool Validate()
		{
			var isValid = true;

			if (String.IsNullOrWhiteSpace(LastName)) isValid = false;
			if (String.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

			return isValid;
		}
	}
}
