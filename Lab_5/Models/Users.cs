using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5.Models
{
	public class Users
	{
		/// <summary>
		/// Data members with getter and setter properties.
		/// </summary>
		public int userId { get; set; }
		public string userFirstName { get; set; }
		public string userLastName { get; set; }
		public string userZipCode { get; set; }
		public string userProvince { get; set; }
		public string userAddress { get; set; }
		public string userCity { get; set; }
		public int userPhone { get; set; }
		public string userEmail { get; set; }

		
		/// <summary>
		/// Default constructor
		/// </summary>
		public Users()
		{

		}

		/// <summary>
		/// Parameterized Constructor
		/// </summary>
		public Users(int userId, string userFirstName, string userLastName, string userZipCode, string userProvince, string userAddress, string userCity, int userPhone, string userEmail)
		{
			this.userId = userId;
			this.userFirstName = userFirstName;
			this.userLastName = userLastName;
			this.userZipCode = userZipCode;
			this.userProvince = userProvince;
			this.userAddress = userAddress;
			this.userCity = userCity;
			this.userPhone = userPhone;
			this.userEmail = userEmail;
		}
		
	}
}

