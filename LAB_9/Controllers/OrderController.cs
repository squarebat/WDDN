using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShop.Models;
namespace OnlineShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _OrderRepo;
        private readonly IProductRepository _productRepo;
        public OrderController(IOrderRepository OrderRepo, IProductRepository productRepo)
        {
            _OrderRepo = OrderRepo;
            _productRepo = productRepo;
        }
        public ViewResult Index()
        {
            var model = _OrderRepo.GetAllOrders();
            return View(model);
        }
        public ViewResult Details(int Id)
        {
            Order Order = _OrderRepo.GetOrder(Id);
            if (Order == null)
            {
                Response.StatusCode = 404;
            }
            return View(Order);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            var customers = _OrderRepo.GetCustomers();
            var products = _OrderRepo.GetProducts();
            ViewData["CustomerID"] = new SelectList(customers, "ID", "Name");
            ViewData["ProductID"] = new SelectList(products, "ID", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Order model)
        {
            Product prod = _productRepo.GetProduct(model.ProductID);
            Order newOrder = new Order
            {
                CustomerID = model.CustomerID,
                ProductID = model.ProductID,
                Amount = (float)Convert.ToDouble(prod.Amount),
                Date = DateTime.Now
            };
            _OrderRepo.Add(newOrder);
            return RedirectToAction("Details", new { id = newOrder.ID });
        }
        [Authorize]

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Order Order = _OrderRepo.GetOrder(id);
            ViewData["CustomerID"] = new SelectList(_OrderRepo.GetCustomers(), "ID", "Name");
            ViewData["ProductID"] = new SelectList(_OrderRepo.GetProducts(), "ID", "Name");
            return View(Order);
        }
        [HttpPost]
        public IActionResult Edit(Order model)
        {
            Order Order = _OrderRepo.GetOrder(model.ID);
            Order.CustomerID = model.CustomerID;
            Order.ProductID = model.ProductID;
            Order updatedOrder = _OrderRepo.Update(Order);
            return RedirectToAction("Index");
        }
        [Authorize]

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Order Order = _OrderRepo.GetOrder(id);
            if (Order == null)
            {
                return NotFound();
            }
            return View(Order);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var Order = _OrderRepo.GetOrder(id);
            _OrderRepo.Delete(Order.ID);
            return RedirectToAction("Index");
        }
    }
}
