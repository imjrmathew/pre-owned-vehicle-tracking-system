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
    
    public partial class tblpolicecomplaint
    {
        public int policecompliantid { get; set; }
        public Nullable<int> regid { get; set; }
        public string details { get; set; }
        public Nullable<int> loginid { get; set; }
    
        public virtual tbllogin tbllogin { get; set; }
        public virtual tblvehiclereg tblvehiclereg { get; set; }
    }
}