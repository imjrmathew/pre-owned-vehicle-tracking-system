//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblreg
    {
        public int regid { get; set; }
        public Nullable<int> loginid { get; set; }
        public Nullable<int> cityid { get; set; }
        public string address { get; set; }
        public Nullable<int> districtid { get; set; }
        public string email { get; set; }
    
        public virtual tblcity tblcity { get; set; }
        public virtual tbldistrict tbldistrict { get; set; }
        public virtual tbllogin tbllogin { get; set; }
    }
}