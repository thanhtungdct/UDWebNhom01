//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServiceFastFood
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string RecipientAddress { get; set; }
        public double TotalPrice { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
        public System.DateTime DateCreate { get; set; }
        public string Payment { get; set; }
        public string Note { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}