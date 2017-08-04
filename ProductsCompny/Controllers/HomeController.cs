using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductsCompny.Controllers
{
    public class HomeController : Controller
    {
        ProductCompnyEntities db = new ProductCompnyEntities();

        public ActionResult Index()
        {
            var pro = db.Products.ToList();
            ViewBag.prod = pro;
            return View();
        }



      
    }
}