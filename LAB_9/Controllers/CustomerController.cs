using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _custRepo;
        public CustomerController(ICustomerRepository custRepo)
        {
            _custRepo = custRepo;
        }
        // GET: CustomerController
        public ViewResult Index()
        {
            var model = _custRepo.GetAllCustomers();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            Customer customer = _custRepo.GetCustomer(id);
            if (customer == null)
            {
                Response.StatusCode = 404;
            }
            return View(customer);
        }
        [Authorize]

        [HttpGet]
        // GET: CustomerController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        public IActionResult Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                Customer newCust = new Customer
                {
                    Name = model.Name,
                    Email = model.Email,
                    PhoneNo = model.PhoneNo
                };
                _custRepo.Add(newCust);
                return RedirectToAction("Details", new { id = newCust.ID });
            }
            return View();
        }
        [Authorize]

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Customer cust = _custRepo.GetCustomer(id);
            Customer newCust = new Customer
            {
                ID = cust.ID,
                Name = cust.Name,
                Email = cust.Email,
                PhoneNo = cust.PhoneNo
            };
            return View(newCust);
        }
        [HttpPost]
        public IActionResult Edit(Customer model)
        {
            if (ModelState.IsValid)
            {
                Customer cust = _custRepo.GetCustomer(model.ID);
                cust.Name = model.Name;
                cust.Email = model.Email;
                cust.PhoneNo = model.PhoneNo;
                Customer updatedCust = _custRepo.Update(cust);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [Authorize]
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Customer cust = _custRepo.GetCustomer(id);
            if (cust == null)
            { 
            }
            return View(cust);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var cust = _custRepo.GetCustomer(id);
            _custRepo.Delete(cust.ID);
            return RedirectToAction("Index");
        }
        // GET: CustomerController/Edit/5
        
    }
}
