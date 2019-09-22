using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Models.BL;
using CoreMVC.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class ProductController : BaseController<Product>
    {
        public ProductController()
        {
            bl = new BLProduct();
        }
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            var products = bl.GetAll();
            return View("~/Views/Product/List.cshtml", products);
        }

        public IActionResult View(int id)
        {
            var product = bl.GetByID(id);
            return View("~/Views/Product/View.cshtml", product);
        }

        public IActionResult Edit(int id)
        {
            var product = bl.GetByID(id);
            return View("~/Views/Product/Edit.cshtml", product);
        }
    }
}