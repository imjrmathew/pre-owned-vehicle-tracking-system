﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreOwnedVehicle.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class preownedvehicleEntities : DbContext
    {
        public preownedvehicleEntities()
            : base("name=preownedvehicleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblcity> tblcities { get; set; }
        public virtual DbSet<tbldistrict> tbldistricts { get; set; }
        public virtual DbSet<tbllogin> tbllogins { get; set; }
        public virtual DbSet<tblreg> tblregs { get; set; }
        public virtual DbSet<tblvehiclereg> tblvehicleregs { get; set; }
        public virtual DbSet<tblfeedback> tblfeedbacks { get; set; }
        public virtual DbSet<tblinsurance> tblinsurances { get; set; }
        public virtual DbSet<tblpolicecomplaint> tblpolicecomplaints { get; set; }
        public virtual DbSet<tblpollution> tblpollutions { get; set; }
        public virtual DbSet<tblservice> tblservices { get; set; }
    }
}