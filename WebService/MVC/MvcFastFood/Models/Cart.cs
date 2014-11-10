using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace MvcFastFood.Models
{
    public class Cart
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int Discount { get; set; }
        public byte[] Image { get; set; }

        public static List<Cart> myCart{
            set { HttpContext.Current.Session["mycart"] = value; }
            get
            {
                if (HttpContext.Current.Session["mycart"] == null)
                {
                    List<Cart> mycart = new List<Cart>();
                    HttpContext.Current.Session["mycart"] = mycart;
                    return mycart;
                }
                return (List<Cart>)HttpContext.Current.Session["mycart"];

            }
    }

    }
}