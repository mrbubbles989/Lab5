using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Lab_5.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication;

namespace Lab_5.Controllers
{
	public class AccountController : Controller
	{

		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;
		private readonly ILogger _logger;

		public AccountController(
			UserManager<AppUser> userManager,
			SignInManager<AppUser> signInManager,
			ILogger<AccountController> logger)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_logger = logger;
		}

		private void AddErrors(IdentityResult result)
		{
			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(string.Empty, error.Description);
			}
		}

		private IActionResult RedirectToLocal(string returnUrl)
		{
			if (Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}
			else
			{
				return RedirectToAction(nameof(HomeController.Index));
			}
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Register(string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl)
		{
			ViewData["ReturnUrl"] = returnUrl;
			if (ModelState.IsValid)
			{
				var user = new AppUser { UserName = model.Email, Email = model.Email };
				var result = await _userManager.CreateAsync(user, model.Password);
				if (result.Succeeded)
				{
					_logger.LogInformation("User created a new account with a password.");

					await _signInManager.SignInAsync(user, isPersistent: false);
					_logger.LogInformation("User created a new account with password.");
					return RedirectToLocal(returnUrl);
				}
				AddErrors(result);
			}
			return View(model);
		}
		
	}
}
