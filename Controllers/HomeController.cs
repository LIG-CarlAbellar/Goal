using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using ProjectManagement.Models;
using System.Security.Cryptography;

namespace ProjectManagement.Controllers
{
	public class HomeController : Controller
	{
		LoginDataAccessLayer objLoginData = new LoginDataAccessLayer();

		public IActionResult Index()
		{
			// if (!HttpContext.User.Identity.IsAuthenticated)
			// {
			// 	return RedirectToAction("Login");
			// }
			// else
			// {
			// 	return View();
			// }
			return View();
		}

		[HttpPost]
		public ActionResult Index(Employee employee)
		{
			bool isLogin;
			if (employee.Username != null && employee.Password != null) {
				isLogin = objLoginData.GetEmployeeLoginData(employee.Username.ToString(), employee.Password.ToString());

				if (isLogin) {
					return RedirectToAction("Index", "employee");
				}
				ViewBag.Message = "Login failed";
			}
			else {
				ViewBag.Message = "Please input username and password.";
			}

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
