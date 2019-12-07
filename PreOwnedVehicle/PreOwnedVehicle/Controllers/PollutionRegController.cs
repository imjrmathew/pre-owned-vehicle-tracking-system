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
    public class PollutionRegController : Controller
    {
        preownedvehicleEntities de = new preownedvehicleEntities();
        // GET: PollutionReg
        public ActionResult PollutionVehicleReg()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult PollutionVehicleReg(tblpollution pol)
        {
            int model = de.tblpollutions.Where(a => a.regid == pol.regid).Count();
            if (model == 0)
            {
                ViewBag.dist = de.tbldistricts.ToList();
                ViewBag.cit = de.tblcities.ToList();
                ViewBag.vereg = de.tblvehicleregs.ToList();
                int id = Convert.ToInt32(Session["logid"]);
                pol.loginid = id;
                de.tblpollutions.Add(pol);
                de.SaveChanges();
            }
            else
            {
                TempData["dataalready"] = "Vehicle No has an active PUC certificate. To renew, edit the particular vehicle id";
            }
            return RedirectToAction("PollutionVehicleReg");
        }
        public ActionResult listPollution(int page=1)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var pol = de.tblpollutions.Where(a => a.loginid == logid).ToList();
            return View(pol.ToPagedList(page, 10));
        }
        public ActionResult listPollutiondetails(int? id)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            var details = de.tblpollutions.Find(id);
            return View(details);
        }
        public ActionResult editPollutionsdetails(int? id)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            var detail = de.tblpollutions.Find(id);
            return View(detail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult editPollutionsdetails(tblpollution pol)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            tblpollution ps = de.tblpollutions.Find(pol.pollutionid);
            ps.regid = pol.regid;
            ps.renewdate = pol.renewdate;
            de.SaveChanges();
            return RedirectToAction("listPollution");
        }
        public ActionResult PollutionHome()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a => a.districtname).ToList();
            var vehcount = de.tblvehicleregs.ToList();
            TempData["vehcountreg"] = vehcount.Count;
            var pollcount = de.tblpollutions.ToList();
            TempData["pollcountreg"] = pollcount.Count;
            return View();
        }
        public ActionResult pollutionname()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var pollutionusername = de.tbllogins.Where(a => a.loginid == logid).ToList();
            ViewBag.username = pollutionusername[0].username;
            return View();
        }
        public ActionResult pollutionmailid()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var pollutionmailid = de.tblregs.Where(a => a.loginid == logid).ToList();
            ViewBag.mailid = pollutionmailid[0].email;
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