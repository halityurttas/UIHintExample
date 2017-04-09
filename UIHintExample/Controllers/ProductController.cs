using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIHintExample.Models;

namespace UIHintExample.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var context = new FakeContext();
            var data = context.Products;
            var model = data.Select(s => new ProductListViewModel { Id = s.Id, Name = s.Name, Price = s.Price }).ToList();
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var context = new FakeContext();
            var data = context.Products.FirstOrDefault(f => f.Id == id);
            var model = new ProductEditViewModel { Id = data.Id, Description = data.Description, Name = data.Name, Price = data.Price };
            return View(model);
        }
    }
}