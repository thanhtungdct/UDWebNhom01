using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PagedList;

namespace MvcFastFood.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //FastFoodSevice.FastFoodServiceClient db = new FastFoodSevice.FastFoodServiceClient();
        FastFoodServiceWeb.WedMVCClient db = new FastFoodServiceWeb.WedMVCClient();
        public ActionResult Index(int? page)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var listpr = db.getAllProduct().ToList();
            foreach (var s in listpr)
            {
                if (s.CategoryID == 2)
                {
                    if (db.CheckQuantity(s.ProductID)> 0)
                    {
                        TempData[s.ProductID] = "Con";
                    }
 
                }
            }

            return View(listpr.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Map()
        {
            return View();
        }
        public ActionResult Search(string name)
        {
            var pro = db.getProductByName(name).ToList();
            foreach (var s in pro)
            {
                if (s.CategoryID == 2)
                {
                    if (db.CheckQuantity(s.ProductID) > 0)
                    {
                        TempData[s.ProductID] = "Con";
                    }

                }
            }
            return View(pro);
        }
        public ActionResult getCategory()
        {
            var cate = db.getAllCategory();
            return View(cate);
        }
        public ActionResult getProductByCategory(int categoryID)
        {

            var products = db.getProductByCategory(categoryID);
            if (categoryID == 2)
            {
                foreach(var s in products)
                {
                   
                        if (db.CheckQuantity(s.ProductID) > 0)
                        {
                            TempData[s.ProductID] = "Con";
                        }

                }
            }
            return View(products);
 
        }
        public ActionResult getProductByID(string productID)
        {
            var product = db.getProductByID(productID);
            if (product.CategoryID == 2)
            {
                if (db.CheckQuantity(product.ProductID) > 0)
                {
                    TempData[product.ProductID] = "Con";
                }
 
            }
            return View(product);
        }


    }
}
