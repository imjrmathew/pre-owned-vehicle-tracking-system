using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PreOwnedVehicle.Models;

namespace PreOwnedVehicle.Controllers
{
    public class AdminController : Controller
    {
        preownedvehicleEntities de = new preownedvehicleEntities();
        // GET: Admin
        public ActionResult AdminHome()
        {
            var excount = de.tbllogins.Where(a => a.isdeleted == false && a.status == true).ToList();
            TempData["excountreg"] = excount.Count;
            var newcount = de.tbllogins.Where(a => a.isdeleted == false && a.status == false).ToList();
            TempData["newcountreg"] = newcount.Count;
            var feedcount = de.tblfeedbacks.Where(a=>a.isread==false).ToList();
            TempData["feedcountreg"] = feedcount.Count;
            var vehcount = de.tblvehicleregs.ToList();
            TempData["vehcountreg"] = vehcount.Count;
            return View();
        }
        public ActionResult listDistrict()
        {
            var listdist = de.tbldistricts.ToList();
            return View(listdist);
        }
        public ActionResult listCity()
        {
            ViewBag.dist = de.tbldistricts.OrderBy(a=>a.districtname).ToList();
            var listcit = de.tblcities.ToList();
            return View(listcit);
        }
        public ActionResult AddDistrict()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDistrict(tbldistrict dist)
        {
            de.tbldistricts.Add(dist);
            de.SaveChanges();
            return RedirectToAction("listDistrict");
        }
    
        public ActionResult AddCity()
        {
            ViewBag.dist = de.tbldistricts.OrderBy(a=>a.districtname).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddCity(tblcity cty)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            de.tblcities.Add(cty);
            de.SaveChanges();
            return RedirectToAction("listCity");
        }
        public ActionResult listRTOreg()
        {
            TempData["id"] = 2;
            var list = de.tblregs.Where(a=>a.tbllogin.roleid==2 && a.tbllogin.status==false && a.tbllogin.isdeleted==false).ToList();
            return View(list);
        }
        public ActionResult listPolicereg()
        {
            TempData["id"] = 3;
            var list = de.tblregs.Where(a => a.tbllogin.roleid == 3 && a.tbllogin.status == false && a.tbllogin.isdeleted == false).ToList();
            return View(list);
        }
        public ActionResult listInsurancereg()
        {
            TempData["id"] = 4;
            var list = de.tblregs.Where(a => a.tbllogin.roleid == 4 && a.tbllogin.status == false && a.tbllogin.isdeleted == false).ToList();
            return View(list);
        }
        public ActionResult listPollutionreg()
        {
            TempData["id"] = 5;
            var list = de.tblregs.Where(a => a.tbllogin.roleid == 5 && a.tbllogin.status == false && a.tbllogin.isdeleted == false).ToList();
            return View(list);
        }
        public ActionResult listServicereg()
        {
            TempData["id"] = 6;
            var list = de.tblregs.Where(a => a.tbllogin.roleid == 6 && a.tbllogin.status == false && a.tbllogin.isdeleted == false).ToList();
            return View(list);
        }
        public ActionResult Approve(int? id)
        {
            var tbllog = de.tbllogins.Find(id);
            tbllog.status = true;
            de.SaveChanges();
            int ids=Convert.ToInt32(TempData["id"]);
            if (ids == 2)
            {
                return RedirectToAction("listRTOreg");
            }
            else if(ids==3)
            {
                return RedirectToAction("listPolicereg");
            }
            else if(ids==4)
            {
                return RedirectToAction("listInsurancereg");
            }
            else if(ids==5)
            {
                return RedirectToAction("listPollutionreg");
            }
            else if(ids==6)
            {
                return RedirectToAction("listServicereg");
            }
            else
            {
                return RedirectToAction("AdminHome");
            }
        }
        public ActionResult Reject(int? id)
        {
            var tbllog = de.tbllogins.Find(id);
            tbllog.status = false;
            tbllog.isdeleted = true;
            de.SaveChanges();
            int ids = Convert.ToInt32(TempData["id"]);
            if (ids == 2)
            {
                return RedirectToAction("listRTOreg");
            }
            else if (ids == 3)
            {
                return RedirectToAction("listPolicereg");
            }
            else if (ids == 4)
            {
                return RedirectToAction("listInsurancereg");
            }
            else if (ids == 5)
            {
                return RedirectToAction("listPollutionreg");
            }
            else if (ids == 6)
            {
                return RedirectToAction("listServicereg");
            }
            else
            {
                return RedirectToAction("AdminHome");
            }
        }
        public ActionResult listfeedback()
        {
            var listfeed=de.tblfeedbacks.Where(a=>a.isread==false).ToList();
            return View(listfeed);
        }
        public ActionResult readfeedback(int id)
        {
            var fb = de.tblfeedbacks.Where(a => a.feedid == id).SingleOrDefault();
            fb.isread = true;
            de.SaveChanges();
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetEdit(int passid)
        {
            var det = de.tbldistricts.Where(a => a.districtid == passid).SingleOrDefault();
            var did = det.districtid;
            var dname = det.districtname;
            var result = new { did, dname };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult UpdateDist(tbldistrict dist)
        {

            tbldistrict dists = de.tbldistricts.Where(a => a.districtid == dist.districtid).SingleOrDefault();
            dists.districtname = dist.districtname;
            de.SaveChanges();
            return Json(new{result=true,message="Data Updated Succesfully."},JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetEditCity(int passid)
        {
            ViewBag.dist = de.tbldistricts.ToList();
            var det = de.tblcities.Where(a => a.cityid == passid).SingleOrDefault();
            var cid = det.cityid;
            var cname = det.cityname;
            var did = det.districtid;
            var result = new { cid, cname, did};
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult UpdateCity(tblcity cit)
        {
            tblcity cits = de.tblcities.Where(a => a.cityid == cit.cityid).SingleOrDefault();
            cits.cityname = cit.cityname;
            cits.districtid = cit.districtid;
            de.SaveChanges();
            return Json(new { result = true, message = "Data Updated Succesfully." }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult adminname()
        {
            int logid = Convert.ToInt32(Session["logid"]);
            var adminusername = de.tbllogins.Where(a => a.loginid == logid).ToList();
            ViewBag.username = adminusername[0].username;
            return View();
        }
        public ActionResult EditPro()
        {
            int logid = Convert.ToInt32(Session["logid"]);
            var det = de.tbllogins.Where(a => a.loginid == logid).SingleOrDefault();
            var lid = det.loginid;
            var uname = det.username;
            var pwd = det.password;
            var result = new { lid, uname, pwd};
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult EditProfile(tbllogin log)
        {
            tbllogin logs = de.tbllogins.Where(a => a.loginid == log.loginid).SingleOrDefault();
            logs.username = log.username;
            logs.password = log.password;
            de.SaveChanges();
            return Json(new { result = true, message = "Profile Updated Succesfully." }, JsonRequestBehavior.AllowGet);
        }
    }
}