using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace WCFServiceFastFood
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FastFoodService" in both code and config file together.
    public class FastFoodService : IFastFoodService
    {
        WCFServiceFastFood.FastFoodEntities db = new FastFoodEntities();
        #region Product
        /// <summary>
        /// PRODUCTS
        /// </summary>
        /// <returns></returns>
        /// 

        public List<Product> getAllProduct()
        {
            return db.Products.ToList();
        }

        public Product getProductByID(string productID)
        {
            return db.Products.Where(p => p.ProductID == productID).Single();
        }

        public bool insertProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteProduct(string productID)
        {
            try
            {
                var product = db.Products.Where(p => p.ProductID == productID).Single();
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateProduct(Product product)
        {
            try
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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
        #endregion
        #region Category
        /// <summary>
        /// Category
        /// </summary>
        /// <returns></returns>
        /// 


        public List<Category> getAllCategory()
        {
            return db.Categories.ToList();
        }

        public Category getCategoryByID(int categoryID)
        {
            return db.Categories.Where(p => p.ID == categoryID).Single();
        }

        public bool insertCategory(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateCategory(Category category)
        {
            try
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deteteCategory(int categoryID)
        {
            try
            {
                var category = db.Categories.Where(p => p.ID == categoryID).Single();
                db.Categories.Remove(category);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }
        #endregion
        #region Order
        /// <summary>
        /// Order
        /// </summary>
        /// <returns></returns>
        /// 
        public List<Order> getAllOrder()
        {
            return db.Orders.ToList();
        }

        public Order getOrderByID(string orderID)
        {
            return db.Orders.Where(p => p.OrderID == orderID).Single();
        }
        public List<Order> getOrderByStatus(bool status)
        {
            return db.Orders.Where(p => p.Status == status).ToList();
        }

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

        public bool updateOrder(Order order)
        {
            try
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deteteOrder(int orderID)
        {
            try
            {
                var order = db.Categories.Where(p => p.ID == orderID).Single();
                db.Categories.Remove(order);
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
        /// <summary>
        /// OrderDetail
        /// </summary>
        /// <returns></returns>
        /// 
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

        public List<OrderDetail> getOrderDetailByID(string order)
        {
            return db.OrderDetails.Where(p => p.OrderID == order).ToList();
        }
        #endregion
        #region Account
        /// <summary>
        /// Account
        /// </summary>
        /// <returns></returns>
        /// 
        public List<Account> getAllAccount()
        {
            var acc = (from account in db.Accounts
                       select new Account()
                                 {
                                     UserName = account.UserName,
                                     Password = account.Password,
                                     Phone = account.Phone,
                                     Email = account.Email,
                                     Address = account.Address,
                                     UserTypeID = account.UserTypeID,

                                 });

            return db.Accounts.ToList();
        }

        public Account getAccountByID(string userName)
        {
            return db.Accounts.Where(p => p.UserName.Trim() == userName).Single();
        }

        public bool insertAccount(Account account)
        {
            try
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateAccount(Account account)
        {
            try
            {
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deteteAccount(string userName)
        {
            try
            {
                var account = db.Accounts.Where(p => p.UserName == userName).Single();
                db.Accounts.Remove(account);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Account> login(string userName, string passWord)
        {
            var user = (from acc in db.Accounts where acc.UserName == userName && acc.Password == passWord select acc).ToList();
            return user;

        }
        #endregion
        #region Usertype

        /// <summary>
        /// Usertype
        /// </summary>
        /// <returns></returns>
        /// 
        public List<UserType> getAllUserType()
        {
            return db.UserTypes.ToList();
        }

        #endregion

        #region Report
        public List<Order> getOrderByDay(DateTime day)
        {

            var orders = db.Orders.Where(p => p.DateCreate == day && p.Status == true).ToList();
            return orders;
        }
        public List<Order> getOrderByMonth(DateTime month)
        {
            int months = month.Month;
            var orders = db.Orders.Where(p => p.DateCreate.Month == months && p.Status == true).ToList();
            return orders;
        }
        public List<Order> getOrderFromDayToDay(DateTime from, DateTime to)
        {
            var orders = db.Orders.Where(p => p.DateCreate >= from && p.DateCreate < to && p.Status == true).ToList();
            return orders;

        }

        public List<Order> getOrderByYear(int year)
        {
            
            var orders = db.Orders.Where(p => p.DateCreate.Year == year && p.Status == true).ToList();
            return orders;
        }
        public List<Order> getOrderByQuarterly(int quarterly, int year)
        {
           // var orders = db.Orders.ToList();
            switch (quarterly)
            {
                case 1:
                    {

                        var orders1 = db.Orders.Where(p => p.DateCreate.Month >= 1 && p.DateCreate.Month <= 3 && p.DateCreate.Year == year && p.Status == true).ToList();
                        return orders1;
                    }
                case 2:
                    {
                        var orders2 = db.Orders.Where(p => p.DateCreate.Month >= 4 && p.DateCreate.Month <= 6 && p.DateCreate.Year == year && p.Status == true).ToList();
                        return orders2;

                    }
                case 3:
                    {

                        var orders3 = db.Orders.Where(p => p.DateCreate.Month >= 7 && p.DateCreate.Month <= 9 && p.DateCreate.Year == year && p.Status == true).ToList();
                        return orders3;
                    }
                case 4:
                    {
                        var orders4 = db.Orders.Where(p => p.DateCreate.Month >= 10 && p.DateCreate.Month <= 12 && p.DateCreate.Year == year && p.Status == true).ToList();
                        return orders4;
                    }
            }
            return null;

        }
        public List<OrderDetail> getOrderDetailReprort(string OrderID)
        {
            return db.OrderDetails.Where(p => p.OrderID == OrderID).ToList();
        }
        #endregion

    }
}
