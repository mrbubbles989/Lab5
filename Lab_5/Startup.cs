using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Mvc;
using Lab_5.Data;
using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore.Tools;

namespace Lab_5
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			//Want to keep the project compatible with older versions in case companies have not updated yet
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
			//Disable endpoint routing. 
			services.AddMvc(options => options.EnableEndpointRouting = false);
			services.AddRazorPages();
			//Adds all the MVC related services to the project
			services.AddMvc();

			//Adding a connection
			services.AddDbContext<CheckoutContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

			//NTS: Double check this very quickly or you'll get fucked up
			//services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddRoles;
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			//NTS Delete when in a deployment environment
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseMvcWithDefaultRoute();

			app.UseAuthentication();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
