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
    
    public partial class GUEST_RIDES
    {
        public System.DateTime RideDate { get; set; }
        public int GuestID { get; set; }
        public int RideID { get; set; }
    
        public virtual GUEST GUEST { get; set; }
        public virtual RIDE RIDE { get; set; }
    }
}
