using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceFastFood
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WedMVC" in both code and config file together.
    public class WedMVC : IWedMVC
    {
        FastFoodEntities db = new FastFoodEntities();
        #region Product
        public List<Product> getProductByName(string name)
        {
            return db.Products.Where(p=>p.ProductName.Contains(name)).ToList();
        }
        public List<Product> getAllProduct()
        {
            return db.Products.ToList();
        }
        public Product getProductByID(string productID)
        {
            return db.Products.Where(p => p.ProductID == productID).Single();
        }
        public List<Product> search(string productName)
        {
            try
            {
                var products = db.Products.Where(p => p.ProductName.Contains(productName)).ToList();
                return products;

            }
            catch
            {
                return null;
            }

        }
        public List<Product> getProductByCategory(int categoryID)
        {
            try
            {
                var products = db.Products.Where(p => p.CategoryID == categoryID).ToList();
                return products;
            }
            catch
            {
                return null;

            }
        }
        public List<Category> getAllCategory()
        {
            return db.Categories.ToList();
        }
        #endregion
        #region Login
        public List<Account> login(string userName, string passWord)
        {
            var user = (from acc in db.Accounts where acc.UserName == userName && acc.Password == passWord select acc).ToList();
            return user;

        }
        public Account getAccountByID(string userName)
        {
            return db.Accounts.Where(p => p.UserName.Trim() == userName).SingleOrDefault();
        }
        #endregion
        public void register(string userName, string password, string email, string phone, string address, string name)
        {
            Account newacc = new Account();
            newacc.UserName = userName;
            newacc.Password = password;
            newacc.Name = name;
            newacc.Phone = phone;
            newacc.Email = email;
            newacc.Address = address;
            newacc.UserTypeID = 2;
            db.Accounts.Add(newacc);
            db.SaveChanges();           
        }
        #region Order
        public bool insertOrder(Order order)
        {
            try
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region OrderDetail
        public bool insertOrderDetail(OrderDetail orderDetai)
        {
            try
            {
                db.OrderDetails.Add(orderDetai);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion



        
    }
}
