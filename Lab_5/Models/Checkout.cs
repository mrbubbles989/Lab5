using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5.Models
{
	public class Checkout
	{
		/// <summary>
		/// Data members with getter and setter properties.
		/// </summary>
		public int orderId { get; set; }
		public string orderUserId { get; set; }
		public double orderAmount { get; set; }
		public string orderShipName { get; set; }
		public string orderShipAddress { get; set; }
		public string orderCity { get; set; }
		public int orderPhone { get; set; }
		public string orderEmail { get; set; }
		public string orderDate { get; set; }
		public string orderShipped { get; set; }
		public int orderTrackingNumber { get; set; }
		public string postalCode { get; set; }


		/// <summary>
		/// Default constructor
		/// </summary>
		public Checkout()
		{

		}

		/// <summary>
		/// Parameterized Constructor
		/// </summary>
		public Checkout(int orderId, string orderUserId, double orderAmount, string orderShipName, string orderShipAddress, string orderCity, int orderPhone, string orderEmail, string orderDate, string orderShipped, int orderTrackingNumber, string postalCode)
		{
			this.orderId = orderId;
			this.orderUserId = orderUserId;
			this.orderAmount = orderAmount;
			this.orderShipName = orderShipName;
			this.orderShipAddress = orderShipAddress;
			this.orderCity = orderCity;
			this.orderPhone = orderPhone;
			this.orderEmail = orderEmail;
			this.orderDate = orderDate;
			this.orderShipped = orderShipped;
			this.orderTrackingNumber = orderTrackingNumber;
			this.postalCode = postalCode;
		}
	}
}
