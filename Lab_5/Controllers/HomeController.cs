using Lab_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Checkout()
		{
			return View();
		}

		public IActionResult Mens_Tops()
		{
			return View();
		}

		public IActionResult Mens_Bottoms()
		{
			return View();
		}

		public IActionResult Mens_Suits()
		{
			return View();
		}

		public IActionResult Mens_Shoes()
		{
			return View();
		}

		public IActionResult Womens_Bottoms()
		{
			return View();
		}

		public IActionResult Womens_Tops()
		{
			return View();
		}

		public IActionResult Womens_Shoes()
		{
			return View();
		}

		public IActionResult Womens_SkirtsAndDresses()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
