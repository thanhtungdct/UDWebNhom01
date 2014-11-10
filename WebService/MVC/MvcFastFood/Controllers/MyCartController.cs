using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFastFood.FastFoodServiceWeb;
using MvcFastFood.Models;

namespace MvcFastFood.Controllers
{
    public class MyCartController : Controller
    {
        //
        // GET: /MyCart/
        FastFoodServiceWeb.WedMVCClient db = new FastFoodServiceWeb.WedMVCClient();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddCart(string productID)
        {
            string url = Request.UrlReferrer.ToString();
            //Product product = db.getProductByID(productID);
            Product product = db.getProductByID(productID);

            List<Cart> list = new List<Cart>();
            list = Cart.myCart;

            var find = list.Where(p => p.productID == product.ProductID).ToList();
            Cart proInCart = list.Find(p => p.productID == productID);

            Cart cartAdd = new Cart();
            cartAdd.productID = product.ProductID;
            cartAdd.productName = product.ProductName;
            cartAdd.Quantity += 1;
            cartAdd.Discount = (int)product.Discount;
            cartAdd.UnitPrice = (double)product.UnitPrice;
            cartAdd.Image = product.Image;
            if (find.Count > 0)
            {
                proInCart.Quantity += 1;

            }
            else
                Cart.myCart.Add(cartAdd);
            return Redirect(url);
        }
        public ActionResult ViewMyCart()
        {

            List<Cart> list = Cart.myCart;
            return View(list);
        }
        public ActionResult updateProductInCart(string productID, int quantity)
        {
            string url = Request.UrlReferrer.ToString();
            List<Cart> list = Cart.myCart;
            Cart pro = list.Where(p => p.productID == productID).Single();
            pro.Quantity = quantity;
            return Redirect(url);
        }
        public ActionResult deleteProduct(string productID)
        {
            string url = Request.UrlReferrer.ToString();
            List<Cart> list = Cart.myCart;
            var productRemove = list.Where(p => p.productID == productID).ToList();
            foreach (var pro in productRemove)
            {
                Cart.myCart.Remove(pro);
            }
            return Redirect(url);
        }
        public ActionResult Order()
        {
            if (Session["User"] != null)
            {
                var account = db.getAccountByID(Session["User"].ToString());
                ViewBag.account = account;
            }        
                      
            List<Cart> list = Cart.myCart;
            return View(list);
        }

        public ActionResult InsertOrder(string name,string phone,string email,string address, double total, string note)
        {
            if (Session["User"] != null & Cart.myCart != null & total > 0)
            {
                string listpro = " : ";
                string url = Request.UrlReferrer.ToString();
                List<Cart> list = Cart.myCart;
                Order order = new Order();
                order.OrderID = DateTime.Now.Ticks.ToString();
                order.UserID = Session["User"].ToString();
                order.Name = name;
                order.Phone = phone;
                order.RecipientAddress = address;
                order.TotalPrice = total;
                order.Status = false;
                order.Email = email;
                order.DateCreate = DateTime.Today;
                order.Payment = "";
                order.Note = note;
                db.insertOrder(order);
                InsertOrderDetail(order.OrderID);
                foreach (var item in list)
                {
                    listpro = listpro + ", " + item.productName;
                }
                //gui email
                string contentEmail = "Chào " + order.Name + " Các sản phẩm bạn mua gồm " + listpro + " Tổng tiền là " + order.TotalPrice + " VNĐ. Chúng tôi sẽ chuẩn bị cho quý khách vào lúc " + note;
                SendEmail s = new SendEmail();
                s.send_Mail(order.Email, contentEmail);
                Cart.myCart = null;
                return Redirect("/MyCart/OrderSuccess");
            }
            else
                return Redirect("/Mycart/OrderFail");

        }
        public ActionResult  OrderSuccess()
        {
            return View();
        }
        public void InsertOrderDetail(string OrderID)
        {
            List<Cart> list = Cart.myCart;
            foreach (var product in list)
            {
                OrderDetail orderdetail = new OrderDetail();
                orderdetail.OrderID = OrderID;
                orderdetail.ProductID = product.productID;
                orderdetail.Quantity = product.Quantity;
                orderdetail.UnitPrice = (double)product.UnitPrice;
                db.insertOrderDetail(orderdetail);

            }



        }
    }
}

