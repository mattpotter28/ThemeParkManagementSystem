//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThemeParkManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GUEST_SHOPS
    {
        public Nullable<int> GuestID { get; set; }
        public Nullable<int> ShopID { get; set; }
        public int TransactionID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
    
        public virtual GUEST GUEST { get; set; }
        public virtual SHOP SHOP { get; set; }
    }
}
