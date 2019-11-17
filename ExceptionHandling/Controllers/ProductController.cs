using ExceptionHandling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionHandling.Controllers
{
    public class ProductController : Controller
    {
        private List<ProductModel> products = new List<ProductModel>
        {
            new ProductModel
            {
                Id = 1,
                Name = "Elma"
            },
                        new ProductModel
            {
                Id = 2,
                Name = "Armut"
            },            new ProductModel
            {
                Id = 3,
                Name = "Üzüm"
            },
        };

        public ActionResult Index()
        {
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            // Hatanın 2. yakalandığı yer
        }
    }
}