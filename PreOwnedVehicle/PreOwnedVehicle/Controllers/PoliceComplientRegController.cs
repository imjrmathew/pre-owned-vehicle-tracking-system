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
    public class PoliceComplientRegController : Controller
    {
        preownedvehicleEntities de = new preownedvehicleEntities();
        // GET: PoliceComplientReg
        public ActionResult PoliceComplientVehicleReg()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult PoliceComplientVehicleReg(tblpolicecomplaint pcp)
        {
            int model = de.tblpolicecomplaints.Where(a => a.regid == pcp.regid).Count();
            if (model == 0)
            {
                ViewBag.dist = de.tbldistricts.ToList();
                ViewBag.cit = de.tblcities.ToList();
                ViewBag.vereg = de.tblvehicleregs.ToList();
                int id = Convert.ToInt32(Session["logid"]);
                pcp.loginid = id;
                de.tblpolicecomplaints.Add(pcp);
                de.SaveChanges();
            }
            else
            {
                TempData["dataalready"] = "Vehicle No has an active police complaint. To add more complaint edit the particular vehicle id";
            }
            return RedirectToAction("PoliceComplientVehicleReg");
        }
        public ActionResult listPolice(int page=1)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var poli = de.tblpolicecomplaints.Where(a => a.loginid == logid).ToList();
            return View(poli.ToPagedList(page, 10));
        }
        public ActionResult listPolicedetails(int? id)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            var details = de.tblpolicecomplaints.Find(id);
            return View(details);
        }
        public ActionResult editPolicedetails(int? id)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            var detail = de.tblpolicecomplaints.Find(id);
            return View(detail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult editPolicedetails(tblpolicecomplaint pol)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            tblpolicecomplaint pc = de.tblpolicecomplaints.Find(pol.policecompliantid);
            pc.regid = pol.regid;
            pc.details = pol.details;
            de.SaveChanges();
            return RedirectToAction("listPolice");
        }
        public ActionResult PoliceHome()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a => a.districtname).ToList();
            var vehcount = de.tblvehicleregs.ToList();
            TempData["vehcountreg"] = vehcount.Count;
            var policecount = de.tblpolicecomplaints.ToList();
            TempData["policecountreg"] = policecount.Count;
            return View();
        }
        public ActionResult policename()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var policeusername = de.tbllogins.Where(a => a.loginid == logid).ToList();
            ViewBag.username = policeusername[0].username;
            return View();
        }
        public ActionResult policemailid()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var policemailid = de.tblregs.Where(a => a.loginid == logid).ToList();
            ViewBag.mailid = policemailid[0].email;
            return View();
        }
        public ActionResult GetEditPro()
        {
            int logid = Convert.ToInt32(Session["logid"]);
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            var regdetails = de.tblregs.Where(a => a.loginid == logid).SingleOrDefault();
            var regid = regdetails.regid;
            var details = de.tbllogins.Where(a => a.loginid == logid).SingleOrDefault();
            var uname = details.username;
            var pwd = details.password;
            var email = regdetails.email;
            var addr = regdetails.address;
            var cid = regdetails.cityid;
            var did = regdetails.districtid;
            var result = new { regid, logid, uname, pwd, email, addr, cid, did };
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