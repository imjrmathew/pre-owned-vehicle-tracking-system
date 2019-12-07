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
    public class ServiceRegController : Controller
    {
        preownedvehicleEntities de = new preownedvehicleEntities();
        // GET: ServiceReg
        public ActionResult ServiceVehicleReg()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult ServiceVehicleReg(tblservice tbls)
        {
            int model = de.tblservices.Where(a => a.regid == tbls.regid).Count();
            if (model == 0)
            {
                ViewBag.dist = de.tbldistricts.ToList();
                ViewBag.cit = de.tblcities.ToList();
                ViewBag.vereg = de.tblvehicleregs.ToList();
                int id = Convert.ToInt32(Session["logid"]);
                tbls.loginid = id;
                de.tblservices.Add(tbls);
                de.SaveChanges();
            }
            else
            {
                TempData["dataalready"] = "Vehicle No has completed 1st service. To add more services, edit the particular vehicle id";
            }
            return RedirectToAction("ServiceVehicleReg");
        }
        public ActionResult listService(int page=1)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var ser = de.tblservices.Where(a => a.loginid == logid).ToList();
            return View(ser.ToPagedList(page, 10));
        }
        public ActionResult listServicedetails(int? id)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            var details = de.tblservices.Find(id);
            return View(details);
        }
        public ActionResult editServicedetails(int? id)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            var detail = de.tblservices.Find(id);
            return View(detail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult editServicedetails(tblservice serv)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            tblservice rs = de.tblservices.Find(serv.serviceid);
            rs.regid = serv.regid;
            rs.renewdate = serv.renewdate;
            rs.details = serv.details;
            de.SaveChanges();
            return RedirectToAction("listService");
        }
        public ActionResult serviceusername()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var polusername = de.tbllogins.Where(a => a.loginid == logid).ToList();
            ViewBag.username = polusername[0].username;
            return View();
        }
        public ActionResult servicemailid()
        {
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var serviceusermailid = de.tblregs.Where(a => a.loginid == logid).ToList();
            ViewBag.serviceusermailid = serviceusermailid[0].email;
            return View();
        }
        public ActionResult ServiceHome()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a => a.districtname).ToList();
            var vehcount = de.tblvehicleregs.ToList();
            TempData["vehcountreg"] = vehcount.Count;
            var sercount = de.tblservices.ToList();
            TempData["sercountreg"] = sercount.Count;
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