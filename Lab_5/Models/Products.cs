using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5.Models
{
	public class Products
	{
		/// <summary>
		/// Data members with getter and setter properties.
		/// </summary>
		public string productId { get; set; }
		public int productAmount { get; set; }
		public string productName { get; set; }
		public string productDescription { get; set; }
		public double productPrice { get; set; }
		public int productCategoryId { get; set; }
		public string productSize { get; set; }

		/// <summary>
		/// Default constructor
		/// </summary>
		public Products()
		{

		}

		/// <summary>
		/// Parameterized Constructor
		/// </summary>
		public Products(string productId, int productAmount, string productName, string productDescription, double productPrice, int productCategoryId, string productSize )
		{
			this.productId = productId;
			this.productName = productName;
			this.productAmount = productAmount;
			this.productDescription = productDescription;
			this.productPrice = productPrice;
			this.productCategoryId = productCategoryId;
			this.productSize = productSize;
		}
	}
}
