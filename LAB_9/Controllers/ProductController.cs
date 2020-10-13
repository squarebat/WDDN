using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepo;
        public ProductController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }
        // GET: ProductController
        public ViewResult Index()
        {
            var model = _productRepo.GetAllProducts();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            Product Product = _productRepo.GetProduct(id);
            if (Product == null)
            {
                Response.StatusCode = 404;
            }
            return View(Product);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                Product newproduct = new Product
                {
                    Name = model.Name,
                    Description = model.Description,
                    Amount = model.Amount
                };
                _productRepo.Add(newproduct);
                return RedirectToAction("Details", new { id = newproduct.ID });
            }
            return View();
        }
        [Authorize]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Product product = _productRepo.GetProduct(id);
            Product newProduct = new Product
            {
                ID = product.ID,
                Name = product.Name,
                Description = product.Description,
                Amount = product.Amount
            };
            return View(newProduct);
        }
        [HttpPost]
        public IActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                Product product = _productRepo.GetProduct(model.ID);
                product.Name = model.Name;
                product.Description = model.Description;
                product.Amount = model.Amount;
                Product updatedproduct = _productRepo.Update(product);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product product = _productRepo.GetProduct(id);
            if (product == null)
            {
            }
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _productRepo.GetProduct(id);
            _productRepo.Delete(product.ID);
            return RedirectToAction("Index");
        }
    }
}
