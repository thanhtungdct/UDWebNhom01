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
            return db.Products.ToList(); // lấy tất cả các sản phẩm 
        }

        public Product getProductByID(string productID)
        {
            return db.Products.Where(p => p.ProductID == productID ).Single();
            //lấy sản phẩm theo mã

        }

        public bool insertProduct(Product product)
        {
            try
            {
                db.Products.Add(product);// thêm một sản phẩm mới vào table Product
                db.SaveChanges();
                if (product.CategoryID == 2)// nếu sản phẩm thêm vào là thức uống thì thêm vào kho
                {
                    Storage storage = new Storage();// tạo 1 đối tượng Storage để thêm vào kho
                    storage.ProductID = product.ProductID;
                    storage.Quantity = 0;
                    storage.DateUpdate = DateTime.Now;
                    db.Storages.Add(storage);// thêm vào kho
                    db.SaveChanges();
                }
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
                var product = db.Products.Where(p => p.ProductID == productID).Single();// xóa sản phẩm theo mã productID
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
                db.Entry(product).State = EntityState.Modified;// update sản phẩm khi thay đổi
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
                var products = db.Products.Where(p => p.ProductName.Contains(productName)).ToList();//lấy ra danh sách các sản phẩm có tên chứa các ký tự cần tìm
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
                //Lấy danh sách sản phẩm theo danh mục
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
            return db.Orders.ToList();//lấy ra danh sách các hóa đơn bán
        }

        public Order getOrderByID(string orderID)
        {
            return db.Orders.Where(p => p.OrderID == orderID).Single();
            //lấy thông tin hóa đơn theo mã hóa đơn
        }
        public List<Order> getOrderByStatus(bool status)
        {
            return db.Orders.Where(p => p.Status == status).ToList();
            //lấy ra danh sách sản phẩm theo trạng thái (đã giao, chưa giao)
        }

        public bool insertOrder(Order order)
        {
            try
            {
                db.Orders.Add(order);// thêm mới một hóa đơn bán vào table
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
                db.Entry(order).State = EntityState.Modified;// update order
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
                var order = db.Categories.Where(p => p.ID == orderID).Single();// delete order
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
                db.OrderDetails.Add(orderDetai);// thêm mới chi tiết hóa đơn bán
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
            // lấy danh sách cái chi tiết hóa đơn theo mã hóa đơn
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
            return db.Accounts.ToList();
            //lấy ra danh sách người dùng
        }

        public Account getAccountByID(string userName)
        {
            return db.Accounts.Where(p => p.UserName.Trim() == userName).Single();
            // lấy ra một người dùng theo tên đăng nhập
        }

        public bool insertAccount(Account account)
        {
            try
            {
                db.Accounts.Add(account);// thêm mới tài khoản
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
                db.Entry(account).State = EntityState.Modified;// update tài khoản
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
                var account = db.Accounts.Where(p => p.UserName == userName).Single();//lấy ra tài khoản đăng nhập theo tên đăng nhập

                db.Accounts.Remove(account);// xóa tài khoản
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
            // kiểm tra đăng nhập
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
            //lấy ra danh sách các loại user
        }

        #endregion

        #region Report
        public List<Order> getOrderByDay(DateTime day)
        {

            var orders = db.Orders.Where(p => p.DateCreate == day && p.Status == true).ToList();
            //lấy ra các hóa đơn bán trong ngày với tình trạng đã giao hàng
            return orders;
        }
        public List<Order> getOrderByMonth(DateTime month)
        {
            int months = month.Month;
            var orders = db.Orders.Where(p => p.DateCreate.Month == months && p.Status == true).ToList();
            //lấy danh sách các hóa đơn bán trong tháng với tình trạng đã giao hàng
            return orders;
        }
        public List<Order> getOrderFromDayToDay(DateTime from, DateTime to)
        {
            var orders = db.Orders.Where(p => p.DateCreate >= from && p.DateCreate < to && p.Status == true).ToList();
            // lấy danh sách các hóa đơn bán từ ngày ... đến ngày ... và tình trạng đã giao hàng
            return orders;

        }

        public List<Order> getOrderByYear(int year)
        {

            var orders = db.Orders.Where(p => p.DateCreate.Year == year && p.Status == true).ToList();
            // lấy danh sách các hóa đơn bán trong năm với tình trạng đã giao hàng
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
                        //lấy danh sách các hóa đơn bán trong quý 1 (từ tháng 1-tháng 3)
                        return orders1;
                    }
                case 2:
                    {
                        var orders2 = db.Orders.Where(p => p.DateCreate.Month >= 4 && p.DateCreate.Month <= 6 && p.DateCreate.Year == year && p.Status == true).ToList();
                        // lấy danh sách các hóa đơn bán trong quý 2 (từ tháng 4 - tháng 6)
                        return orders2;

                    }
                case 3:
                    {

                        var orders3 = db.Orders.Where(p => p.DateCreate.Month >= 7 && p.DateCreate.Month <= 9 && p.DateCreate.Year == year && p.Status == true).ToList();
                        //Lấy danh sách các hóa đơn bán trong quý 3 (từ tháng 7-tháng 9)
                        return orders3;
                    }
                case 4:
                    {
                        var orders4 = db.Orders.Where(p => p.DateCreate.Month >= 10 && p.DateCreate.Month <= 12 && p.DateCreate.Year == year && p.Status == true).ToList();
                        //lấy danh sách các hóa đơn bán trong quý 4 (từ tháng 10-tháng 12)
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
        #region Order import
        public bool InsertOrderImport(OrderImport orderImport)
        {
            try
            {
                db.OrderImports.Add(orderImport);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertOrderImportDetail(OrderImportDetail orderImportDetail)
        {
            try
            {
                db.OrderImportDetails.Add(orderImportDetail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Storage GetProductInStorage(string productID)
        {
            Storage st = db.Storages.Where(p => p.ProductID == productID).FirstOrDefault();
            return st;

        }
        public bool InsertProductToStorage(string productID, int quantity)
        {
            try
            {
                Storage st = new Storage();
                st.ProductID = productID;
                st.Quantity = quantity;
                st.DateUpdate = DateTime.Now;
                db.Storages.Add(st);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool UpdateProductToStorage(string productID, int quantity)
        {
            try
            {
                Storage st = (from s in db.Storages where s.ProductID == productID orderby s.DateUpdate descending select s).FirstOrDefault();

                // db.Storages.Where(p => p.ProductID == productID).FirstOrDefault();
                if (st != null)
                {
                    Storage st2 = new Storage();
                    st2.Quantity = quantity + (int)st.Quantity;
                    st2.ProductID = productID;
                    st2.DateUpdate = DateTime.Now;
                    db.Storages.Add(st2);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        public List<Storage> Storage(DateTime date)
        {

            List<Storage> storage = new List<Storage>();
    
            var listproduct = db.Products.Where(p => p.CategoryID == 2).ToList();// lấy danh sách các sản phẩm cần quản lý tồn kho(sản phẩm có thể có trong kho)
            foreach (var s in listproduct)
            {
                Storage st = (from pro in db.Storages where s.ProductID == pro.ProductID && pro.DateUpdate <= date orderby pro.DateUpdate descending select pro).FirstOrDefault();
                // lấy ra sản phẩm có trong kho với ngày cập nhật gần nhất
                if (st != null)
                {
                    st.Product = null;
                    storage.Add(st);// thêm vào danh sách tồn kho
                }
            }
            
                return storage;
        }


    }
}
