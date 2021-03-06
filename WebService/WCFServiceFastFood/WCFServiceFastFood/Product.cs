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
    
    public partial class Product
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.OrderImportDetails = new HashSet<OrderImportDetail>();
            this.Storages = new HashSet<Storage>();
        }
    
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Description { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<bool> Display { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderImportDetail> OrderImportDetails { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
