using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceFastFood
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFastFoodService" in both code and config file together.
    [ServiceContract]

    public interface IFastFoodService
    {

        #region Products
        /// <summary>
        ///  Products
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Product> getAllProduct();
        [OperationContract]
        Product getProductByID(string productID);
        [OperationContract]
        bool insertProduct(Product product);
        [OperationContract]
        bool deleteProduct(string productID);
        [OperationContract]
        bool updateProduct(Product product);
        [OperationContract]
        List<Product> search(string productName);
        [OperationContract]
        List<Product> getProductByCategory(int categoryID);
        #endregion
        #region Category
        /// <summary>
        /// Category
        /// </summary>
        /// <returns></returns>
        /// 
        [OperationContract]
        List<Category> getAllCategory();
        [OperationContract]
        Category getCategoryByID(int categoryID);
        [OperationContract]
        bool insertCategory(Category category);
        [OperationContract]
        bool updateCategory(Category category);
        [OperationContract]
        bool deteteCategory(int categoryID);
        #endregion
        #region Order
        /// <summary>
        /// Order
        /// </summary>
        /// <returns></returns>
        /// 

        [OperationContract]
        List<Order> getAllOrder();
        [OperationContract]
        Order getOrderByID(string orderID);
        [OperationContract]
        bool insertOrder(Order order);
        [OperationContract]
        bool updateOrder(Order order);
        [OperationContract]
        bool deteteOrder(int orderID);
        [OperationContract]
        List<Order> getOrderByStatus(bool status);
        #endregion
        #region OrderDetail
        /// <summary>
        /// OrderDetail
        /// </summary>
        /// <returns></returns>
        /// 

        [OperationContract]
        bool insertOrderDetail(OrderDetail orderDetai);
        [OperationContract]
        List<OrderDetail> getOrderDetailByID(string order);
        #endregion
        #region Account
        /// <summary>
        /// Account
        /// </summary>
        /// <returns></returns>
        /// 

        [OperationContract]
        List<Account> getAllAccount();
        [OperationContract]
        Account getAccountByID(string userName);
        [OperationContract]
        bool insertAccount(Account account);
        [OperationContract]
        bool updateAccount(Account account);
        [OperationContract]
        bool deteteAccount(string userName);
        [OperationContract]
        List<Account> login(string userName, string passWord);
        #endregion
        #region Usertype
        /// <summary>
        /// Usertype
        /// </summary>
        /// <returns></returns>
        /// 
        [OperationContract]
        List<UserType> getAllUserType();
        #endregion

        #region Report
        [OperationContract]
        List<Order> getOrderByDay(DateTime day);
        [OperationContract]
        List<Order> getOrderByMonth(DateTime month);
        [OperationContract]
        List<Order> getOrderFromDayToDay(DateTime from, DateTime to);
        [OperationContract]
        List<Order> getOrderByYear(int year);
        [OperationContract]
        List<Order> getOrderByQuarterly(int quarterly,int year);
        [OperationContract]
        List<OrderDetail> getOrderDetailReprort(string OrderID);
        #endregion

    }
}
