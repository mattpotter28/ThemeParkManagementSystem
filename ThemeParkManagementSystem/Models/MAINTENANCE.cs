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
    
    public partial class MAINTENANCE
    {
        public int CaseID { get; set; }
        public int RideID { get; set; }
        public System.DateTime StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Summary { get; set; }
    
        public virtual RIDE RIDE { get; set; }
    }
}
