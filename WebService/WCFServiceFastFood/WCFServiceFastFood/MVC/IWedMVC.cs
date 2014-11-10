using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceFastFood
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWedMVC" in both code and config file together.
    [ServiceContract]
    public interface IWedMVC
    {
        #region Product

        [OperationContract]
        List<Product> getAllProduct();
        [OperationContract]
        Product getProductByID(string productID);
        [OperationContract]
        List<Product> search(string productName);
        [OperationContract]
        List<Product> getProductByCategory(int categoryID);
        [OperationContract]
        List<Category> getAllCategory();
        [OperationContract]
        List<Product> getProductByName(string name);
        #endregion

        #region Login
        [OperationContract]
        List<Account> login(string userName, string passWord);
        [OperationContract]
        Account getAccountByID(string userName);
        [OperationContract]
        void register(string userName, string password, string email, string phone, string address, string name);
        #endregion

        #region Order
        [OperationContract]
        bool insertOrder(Order order);
        #endregion
        #region OrderDetail
        [OperationContract]
        bool insertOrderDetail(OrderDetail orderDetai);
        #endregion
    }
}
