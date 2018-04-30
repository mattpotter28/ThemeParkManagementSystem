﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class tpdatabaseEntities : DbContext
    {
        public tpdatabaseEntities()
            : base("name=tpdatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GUEST> GUESTs { get; set; }
        public virtual DbSet<GUEST_SHOPS> GUEST_SHOPS { get; set; }
        public virtual DbSet<INVENTORY> INVENTORies { get; set; }
        public virtual DbSet<MAINTENANCE> MAINTENANCEs { get; set; }
        public virtual DbSet<RIDE> RIDES { get; set; }
        public virtual DbSet<SHOPLOOKUP> SHOPLOOKUPs { get; set; }
        public virtual DbSet<SHOP> SHOPS { get; set; }
        public virtual DbSet<STAFF> STAFFs { get; set; }
        public virtual DbSet<STAFFLOOKUP> STAFFLOOKUPs { get; set; }
        public virtual DbSet<TICKET> TICKETs { get; set; }
        public virtual DbSet<GUEST_RIDES> GUEST_RIDES { get; set; }
        public virtual DbSet<GUEST_TICKET> GUEST_TICKET { get; set; }
        public virtual DbSet<RIDES_STAFF> RIDES_STAFF { get; set; }
        public virtual DbSet<SHOP_STAFF> SHOP_STAFF { get; set; }
        public virtual DbSet<TICKETLOOKUP> TICKETLOOKUPs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual ObjectResult<Nullable<int>> RideCount(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2, Nullable<int> rideNum)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            var rideNumParameter = rideNum.HasValue ?
                new ObjectParameter("rideNum", rideNum) :
                new ObjectParameter("rideNum", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("RideCount", date1Parameter, date2Parameter, rideNumParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CalculateTicketRevenue(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CalculateTicketRevenue", date1Parameter, date2Parameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> revenue(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("revenue", date1Parameter, date2Parameter);
        }
    
        public virtual ObjectResult<string> GetEmpTypes(Nullable<int> typeID)
        {
            var typeIDParameter = typeID.HasValue ?
                new ObjectParameter("typeID", typeID) :
                new ObjectParameter("typeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetEmpTypes", typeIDParameter);
        }
    
        public virtual ObjectResult<string> GetShopTypes(Nullable<int> typeID)
        {
            var typeIDParameter = typeID.HasValue ?
                new ObjectParameter("typeID", typeID) :
                new ObjectParameter("typeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetShopTypes", typeIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> ticketrevenue(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ticketrevenue", date1Parameter, date2Parameter);
        }
    
        public virtual ObjectResult<Nullable<int>> topRides(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("topRides", date1Parameter, date2Parameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Guestcount(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2, Nullable<int> rideNum)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            var rideNumParameter = rideNum.HasValue ?
                new ObjectParameter("rideNum", rideNum) :
                new ObjectParameter("rideNum", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Guestcount", date1Parameter, date2Parameter, rideNumParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> shoprevenue(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("shoprevenue", date1Parameter, date2Parameter);
        }
    }
}
