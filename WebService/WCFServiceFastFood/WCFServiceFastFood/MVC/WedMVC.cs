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
        public List<Product> getAllProduct()
        {
            try { return db.Products.Where(p => p.Display == true).ToList(); }
            catch { return null; }
            
            //lấy tất cả các danh sách sản phẩm 

        }
        public Product getProductByID(string productID)
        {
            return db.Products.Where(p => p.ProductID == productID&&p.Display==true).Single();
            // lấy sản phẩm theo mã
        }
        public List<Product> getProductByName(string productName)
        {
            try
            {
                if (string.IsNullOrEmpty(productName))
                {
                    return getAllProduct();
                }
                var products = db.Products.Where(p => p.ProductName.Contains(productName)&&p.Display==true).ToList();
                // lấy các sản phẩm mà tên sản phẩm chứa các từ cần tìm 
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
                //lấy danh sách sản phẩm theo mã
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
            // lấy danh sách các danh mục
        }
        #endregion
        #region Login
        public List<Account> login(string userName, string passWord)
        {
            var user = (from acc in db.Accounts where acc.UserName == userName && acc.Password == passWord select acc).ToList();
            //lấy ra user đăng nhập
            return user;

        }
        public Account getAccountByID(string userName)
        {
            return db.Accounts.Where(p => p.UserName.Trim() == userName).Single();
            //lấy ra tài khoản đăng nhập
        }

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
            db.Accounts.Add(newacc);// thêm mới tài khoản khi người dùng đăng ký
            db.SaveChanges();
        }
        #endregion

        #region Order
        public bool insertOrder(Order order)
        {
            try
            {
                db.Orders.Add(order);// thêm mới hóa đơn bán
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

                db.OrderDetails.Add(orderDetai);// thêm chi tiết hóa đơn bán
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        public bool UpdateProductToStorage(string productID, int quantity)
        {
            try
            {
                Storage st = (from s in db.Storages where s.ProductID == productID orderby s.DateUpdate descending select s).FirstOrDefault();
                // lấy ra số lượng sản phẩm có ngày cập nhật mới nhất để trừ kho
                if (st != null)
                {
                    Storage st2 = new Storage();
                    st2.Quantity = st.Quantity - quantity;// trừ đi số lượng trong kho mà người dùng mua
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
        public int CheckQuantity(string productID)
        {
            int q = 0;
            Storage st = (from s in db.Storages where s.ProductID == productID orderby s.DateUpdate descending select s).FirstOrDefault();
            if (st != null)
            {
                q=st.Quantity;// lấy ra số lượng sản phẩm trong kho theo từng sản phẩm
            }
            return q;
        }
    }
}
