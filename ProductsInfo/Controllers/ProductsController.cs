using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductsInfo.Models;
using System.Data.Entity;

namespace ProductsInfo.Controllers
{
    public class ProductsController : Controller
    {
        private ProductEntities db = new ProductEntities();
        // GET: Products
        public ActionResult GetAll()
        {            
            return View(db.Products.ToList());
        }
    }
}