using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PreOwnedVehicle.Models;
using PagedList.Mvc;
using PagedList;

namespace PreOwnedVehicle.Controllers
{
    public class VehicleRegController : Controller
    {
        preownedvehicleEntities de = new preownedvehicleEntities();
        // GET: VehicleReg
        public ActionResult RTOhome()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a => a.districtname).ToList();
            var vehcount = de.tblvehicleregs.ToList();
            TempData["vehcountreg"] = vehcount.Count;
            return View();
        }
        public ActionResult RTOVehicleRegDetails()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult RTOVehicleRegDetails(tblvehiclereg vehreg)
        {
            int model = de.tblvehicleregs.Where(a => a.vehicleid == vehreg.vehicleid).Count();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.dist = de.tbldistricts.ToList();
            if (model == 0)
            {
                int chassis = de.tblvehicleregs.Where(a => a.chassisno == vehreg.chassisno).Count();
                if (chassis == 0)
                {
                    int engine = de.tblvehicleregs.Where(a => a.engineno == vehreg.engineno).Count();
                    if (engine == 0)
                    {
                        if (ModelState.IsValid)
                        {
                            int logid = Convert.ToInt32(Session["logid"]);
                            vehreg.loginid = logid;
                            var pic = "/Content/image/" + vehreg.file.FileName;
                            vehreg.file1 = pic;
                            vehreg.file.SaveAs(Server.MapPath(pic));
                            de.tblvehicleregs.Add(vehreg);
                            de.SaveChanges();
                        }
                    }
                    else
                    {
                        TempData["engine"] = "Invalid engine no!";
                        return View();
                    }
                }
                else
                {
                    TempData["chassis"] = "Invalid chassis no!";
                    return View();
                }
            }
            else
            {
                TempData["dataalready"] = "Vehicle No is already registered";
                return View();
            }
            return RedirectToAction("RTOVehicleRegDetails");
        }
        public ActionResult listRTO(int page=1)
        {
            int logid = Convert.ToInt32(Session["logid"]);
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            var rto = de.tblvehicleregs.Where(a => a.loginid == logid).ToList();
            return View(rto.ToPagedList(page, 10));
        }
        public ActionResult listRTOdetails(int? id)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            var details = de.tblvehicleregs.Find(id);
            return View(details);
        }
        public ActionResult editRTOdetails(int? id)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            var detail = de.tblvehicleregs.Find(id);
            return View(detail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult editRTOdetails(tblvehiclereg vreg)
        {
            tblvehiclereg reg = de.tblvehicleregs.Find(vreg.regid);
            reg.vehicleid = vreg.vehicleid;
            reg.cityid = vreg.cityid;
            reg.briefdescription = vreg.briefdescription;
            reg.dealername = vreg.dealername;
            reg.address = vreg.address;
            reg.makername = vreg.makername;
            reg.regownername = vreg.regownername;
            reg.permanentaddr = vreg.permanentaddr;
            reg.classfvehicle = vreg.classfvehicle;
            reg.typeofbody = vreg.typeofbody;
            reg.chassisno = vreg.chassisno;
            reg.engineno = vreg.engineno;
            reg.fuel = vreg.fuel;
            reg.color = vreg.color;
            reg.yearofmanf = vreg.yearofmanf;
            reg.seatcapacity = vreg.seatcapacity;
            reg.tax = vreg.tax;
            reg.taxpaidon = vreg.taxpaidon;
            reg.mobile = vreg.mobile;
            de.SaveChanges();
            return RedirectToAction("listRTO");
        }
        public ActionResult rtoname()
        {
            int logid = Convert.ToInt32(Session["logid"]);
            var rtousername = de.tbllogins.Where(a => a.loginid == logid).ToList();
            ViewBag.username = rtousername[0].username;
            return View();
        }
        public ActionResult rtomailid()
        {
            int logid = Convert.ToInt32(Session["logid"]);
            var rtomail = de.tblregs.Where(a => a.loginid == logid).ToList();
            ViewBag.emailid = rtomail[0].email;
            return View();
        }
        public ActionResult GetEditPro()
        {
            int logid = Convert.ToInt32(Session["logid"]);
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            var regdetails = de.tblregs.Where(a => a.loginid == logid).SingleOrDefault();
            var regid=regdetails.regid;
            var details = de.tbllogins.Where(a => a.loginid == logid).SingleOrDefault();
            var uname = details.username;
            var pwd = details.password;
            var email = regdetails.email;
            var addr = regdetails.address;
            var cid = regdetails.cityid;
            var did = regdetails.districtid;
            var result = new { regid,logid,uname,pwd,email,addr,cid, did};
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        
        [HttpPost]
        public ActionResult UpdateEditPro(tblreg re)
        {
            tbllogin lg = de.tbllogins.Where(a => a.loginid == re.loginid).SingleOrDefault();
                lg.username = re.username;
                lg.password = re.password;
                de.SaveChanges();
                tblreg reg = de.tblregs.Where(a => a.regid == re.regid).SingleOrDefault();
                reg.email = re.email;
                reg.address = re.address;
                reg.districtid = re.districtid;
                reg.cityid = re.cityid;
                de.SaveChanges();
           return Json(new { result = true, message = "Data Updated Succesfully." }, JsonRequestBehavior.AllowGet);
        }
    }
}