using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PreOwnedVehicle.Models
{
    [MetadataType(typeof(metatblreg))]
    public partial class tblreg
    {
        public string username { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password doesn't Match")]
        public string confirmpassword { get; set; }
    }

    public partial class metatblreg
    {
        //[Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<int> cityid { get; set; }
        //[Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        //[RegularExpression(@"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$",ErrorMessage = "Only Alphabet!")]
        public string address { get; set; }
        //[Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<int> districtid { get; set; }
        //[Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        //[EmailAddress(ErrorMessage="Not a Valid Email ID!")]
        public string email { get; set; }
    }

    [MetadataType(typeof(metatblvehiclereg))]
    public partial class tblvehiclereg
    {
       // [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public HttpPostedFileBase file { get; set; }
    }
    public partial class metatblvehiclereg
    {
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^(([A-Za-z]){1,3}(-)(?:[0-9]){1,2}(-)(?:[A-Za-z]){1,3}(-)([0-9]){1,4})$", ErrorMessage = "Please Enter a Valid vehicle No!    eg: KL-69-A-7865")]
        public string vehicleid { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<int> cityid { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public string briefdescription { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Only Alphabet!")]
        public string dealername { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Only Alphabet!")]
        public string address { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Only Alphabet!")]
        public string makername { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Only Alphabet!")]
        public string regownername { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Only Alphabet!")]
        public string permanentaddr { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public string classfvehicle { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public string typeofbody { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^(([A-Z0-9]){17})$", ErrorMessage = "Chasis number should be 17 charcters!")]
        public string chassisno { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^(([A-Z0-9]){9})$", ErrorMessage = "Engine number should be 9 charcters!")]
        public string engineno { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^(([a-zA-Z])+)$", ErrorMessage = "Only Alphabet!")]
        public string fuel { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Only Alphabet!")]
        public string color { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public string yearofmanf { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^(([0-9])+)$",ErrorMessage="Only Numbers!")]
        public string seatcapacity { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^(([0-9])+)$", ErrorMessage = "Only Numbers!")]
        public string tax { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString="{0:yyyy/MM/dd}",ApplyFormatInEditMode=true)]
        public Nullable<System.DateTime> taxpaidon { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Mobile No!")]
        public string mobile { get; set; }
    }

    [MetadataType(typeof(metatbllogin))]
    public partial class tbllogin
    {
    }
    public partial class metatbllogin
    {
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public string username { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
    [MetadataType(typeof(metacit))]
    public partial class tblcity
    {
    }
    public partial class metacit
    {
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<int> districtid { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Only Alphabet!")]
        public string cityname { get; set; }
    }
    [MetadataType(typeof(metadist))]
    public partial class tbldistrict
    {
    }
    public partial class metadist
    {
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]+(([ ][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Only Alphabet!")]
        public string districtname { get; set; }
    }
    [MetadataType(typeof(metainsurance))]
    public partial class tblinsurance
    {
    }
    public partial class metainsurance
    {
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<int> regid { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        [RegularExpression(@"^(([0-9])+)$", ErrorMessage = "Only Numbers!")]
        public Nullable<double> amount { get; set; }
        [DisplayFormat(DataFormatString="{0:yyyy/MM/dd}",ApplyFormatInEditMode=true)]
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<System.DateTime> renewdate { get; set; }
    }
    [MetadataType(typeof(metapolice))]
    public partial class tblpolicecomplaint
    {
    }
    public partial class metapolice
    {
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<int> regid { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public string details { get; set; }
    }
    [MetadataType(typeof(metapollution))]
    public partial class tblpollution
    {
    }
    public partial class metapollution
    {
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<int> regid { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<System.DateTime> renewdate { get; set; }
    
    }
    [MetadataType(typeof(metaservice))]
    public partial class tblservice
    {
    }
    public partial class metaservice
    {
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<int> regid { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public Nullable<System.DateTime> renewdate { get; set; }
        [Required(ErrorMessage = "Mandatory", AllowEmptyStrings = false)]
        public string details { get; set; }

    }

}