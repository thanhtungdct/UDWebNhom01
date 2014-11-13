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
        public ActionResult AddCart(string productID)// them san san pham vao gio hàng
        {
            string url = Request.UrlReferrer.ToString();
            try
            {

                //Product product = db.getProductByID(productID);
                Product product = db.getProductByID(productID);
                int totalquatity = 0;
                if (db.CheckQuantity(productID) > 0)
                {
                    totalquatity = db.CheckQuantity(productID);
                }

                List<Cart> list = new List<Cart>();
                list = Cart.myCart;

                var find = list.Where(p => p.productID == product.ProductID).ToList();
                Cart proInCart = list.Find(p => p.productID == productID);

                Cart cartAdd = new Cart();// tạo moi 1 san pham de them vào gio hang
                cartAdd.productID = product.ProductID;
                cartAdd.productName = product.ProductName;
                cartAdd.Quantity += 1;
                cartAdd.UnitPrice = (double)product.UnitPrice;
                cartAdd.totalQuantity = totalquatity;
                cartAdd.Image = product.Image;
                if (find.Count > 0)// kiem tra san pham co trong gio hang chua neu co cap naht so luong , chua thi them moi vào
                {
                    if (proInCart.Quantity < totalquatity)
                    {
                        proInCart.Quantity += 1;
                    }
                }
                else
                    Cart.myCart.Add(cartAdd);
                return Redirect(url);
            }
            catch { }

            return Redirect(url);
        }
        public ActionResult ViewMyCart()
        {

            List<Cart> list = Cart.myCart;
            return View(list); // tra ve danh sách các sản phẩm có trong giỏ hàng
        }
        public ActionResult updateProductInCart(string productID, int quantity)
        {
            string url = Request.UrlReferrer.ToString();
            try
            {
                // update so luong san pham
               
                List<Cart> list = Cart.myCart;
                Cart pro = list.Where(p => p.productID == productID).Single();
                Product pr = db.getProductByID(productID);
                if (pr.CategoryID == 2)// neu san pham la thuc uong , kiem tra so luong trog kho.
                {
                    if (pro.totalQuantity < quantity) // neu so luong trong kho it hon so luong can mua thi thong bao k du so luong
                    {
                        pro.Quantity = pro.totalQuantity;
                        TempData["message"] = "Sản phẩm không đủ số lượng";
                    }
                    else
                    {
                        pro.Quantity = quantity;
                    }
                }
                else
                {
                    pro.Quantity = quantity;
                }
                return Redirect(url);
            }
            catch { }
            return Redirect(url);
        }
        public ActionResult deleteProduct(string productID)
        {
            //xóa sản phẩm ra khỏi giỏ hàng.
            string url = Request.UrlReferrer.ToString();
            try
            {
                List<Cart> list = Cart.myCart;// lay danh sach san pham trong gio hang
                var productRemove = list.Where(p => p.productID == productID).ToList();
                foreach (var pro in productRemove)
                {
                    Cart.myCart.Remove(pro);// xóa san pham ra khoi gio hang
                }
                return Redirect(url);
            }
            catch { }
            return Redirect(url);

        }
        public ActionResult Order()
        {
            if (Session["User"] != null)
            {
                var account = db.getAccountByID(Session["User"].ToString());// lấy thông tin tài khoản
                ViewBag.account = account;
            }        
                      
            List<Cart> list = Cart.myCart;
            return View(list);
        }

        public ActionResult InsertOrder(string name,string phone,string email,string address, double total, string note)
        {
            // them moi hoa don
            if (Session["User"] != null & Cart.myCart != null & total > 0)
            {
                try
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
                    s.send_Mail(order.Email, contentEmail);// gửi mail
                    Cart.myCart = null;
                    return Redirect("/MyCart/OrderSuccess");
                }
                catch {
                    return Redirect("/Mycart/OrderFail");
                }
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
            // them chi tiet hoa don
            try
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
            catch { 
            }



        }
    }
}

