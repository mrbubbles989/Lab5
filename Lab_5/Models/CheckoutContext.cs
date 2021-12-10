using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab_5.Models
{
	public class CheckoutContext : DbContext
	{
		public CheckoutContext(DbContextOptions<CheckoutContext> options): base(options)
		{

		}

		public DbSet<Checkout> Checkouts { get; set; }
	}
}
