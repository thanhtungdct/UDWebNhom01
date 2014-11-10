using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFastFood.FastFoodServiceWeb;
using MvcFastFood.Models;

namespace MvcFastFood.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        FastFoodServiceWeb.WedMVCClient db = new FastFoodServiceWeb.WedMVCClient();

        public ActionResult Login(string userName,string passWord)
        {
            string url = Request.UrlReferrer.ToString();
            try
            {
                Account[] acc =  db.login(userName, passWord);
                
                if (acc.Count() > 0)
                {
                    foreach(Account a in acc)
                    {
                        Session["User"] = a.UserName;
                        Session["Name"] = a.Name;
                    }
                }
                else
                {
                    TempData["IsLogin"] = "Fail";
                }
            }
            catch { 
            }

            return Redirect(url);
        }
        public ActionResult Logout()
        {
            string url = Request.UrlReferrer.ToString();
            Session["User"] = null;
            Session["Name"] = null;
            return Redirect(url);

        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(AccountModel acc)
        {
            if(ModelState.IsValid)
            {
                var account = db.getAccountByID(acc.UserName);
                    if(account==null)
                    {                        
                        db.register(acc.UserName, acc.Password, acc.Email, acc.Phone, acc.Address, acc.Name);
                        ViewBag.FailRegister = "Đăng kí thành công !";
                    }
                else
                    {
                        ViewBag.FailRegister = "Tên đăng nhập đã có người sử dụng";
                    }
            }
            return View();
        }
    }
}
