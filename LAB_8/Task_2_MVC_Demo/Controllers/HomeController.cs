using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC1.Models;

namespace MVC1.Controllers
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
            ViewBag.HelloMessage = "Hello there!!!";
            test1();
            return View();
        }

        public IActionResult test1()
        {
            int num1 = 10;
            int num2 = 15;
            int sum = num1 + num2;
            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            ViewBag.sum = sum;
            return View("Index");
        }
        [HttpGet]
        public IActionResult test2()
        {
            return View();
        }
        
		[HttpPost]
        public IActionResult test2(IFormCollection formField)
        {
            int num1 = Convert.ToInt32(formField["num1"]);
            int num2 = Convert.ToInt32(formField["num2"]);
            int sum = num1 + num2;
            ViewBag.Sum = "Sum: " + sum;
            return View();
        }
        
		[HttpGet]
        public IActionResult user_registration()
        {
            return View();
        }
        
		[HttpPost]
        public IActionResult user_registration(IFormCollection form)
        {
            string name = form["Name"].ToString();
            string email = form["Email"].ToString();
            string pwd = form["Password"].ToString();
            string phn = form["PhoneNo"].ToString();
            string gender = form["Gender"].ToString();
            string langs = "";
            if (form["C++"].ToString() == "true,false")
            {
                langs = langs + "C++"+", ";
            }
            if (form["Java"].ToString() == "true,false")
            {
                langs = langs + "Java" + ", ";
            }
            if (form["Python"].ToString() == "true,false")
            {
                langs = langs + "Python";
            }
            string details = "";
            details += "Name : " + name + "\n" ;
            details += "Email : " + email + "\n";
            details += "Password : " + pwd + "\n";
            details += "Phone no : " + phn + "\n";
            details += "Gender : " + gender + "";
            details += "Languages known : " + langs + "\n";
            ViewBag.Details = details;
            ViewBag.Nm = "Name : " + name;
            ViewBag.Email = "Email : " + email;
            ViewBag.Pwd = "Password : " + pwd;
            ViewBag.Phn = "Phone no : " + phn;
            ViewBag.Gender = "Gender : " + gender;
            ViewBag.Langs = "Languages known : " + langs;
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
