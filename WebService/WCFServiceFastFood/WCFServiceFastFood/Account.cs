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
    
    public partial class Account
    {
        public Account()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int UserTypeID { get; set; }
        public string Email { get; set; }
    
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
