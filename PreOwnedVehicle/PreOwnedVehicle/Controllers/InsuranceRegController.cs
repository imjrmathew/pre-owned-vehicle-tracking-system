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
    public class InsuranceRegController : Controller
    {
        preownedvehicleEntities de = new preownedvehicleEntities();
        // GET: InsuranceReg
        public ActionResult InsuranceVehicleReg()
        {
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult InsuranceVehicleReg(tblinsurance tbli)
        {
            int model = de.tblinsurances.Where(a => a.regid == tbli.regid).Count();
            if (model == 0)
            {
                ViewBag.cit = de.tblcities.ToList();
                ViewBag.dist = de.tbldistricts.ToList();
                ViewBag.vereg = de.tblvehicleregs.ToList();
                int id = Convert.ToInt32(Session["logid"]);
                tbli.loginid = id;
                de.tblinsurances.Add(tbli);
                de.SaveChanges();
            }
            else
            {
               TempData["dataalready"] = "Vehicle No is already insured. To renew insurance edit the renew date";
            }
            return RedirectToAction("InsuranceVehicleReg");
        }
        public ActionResult listInsurance(int page=1)
        {
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.dist = de.tbldistricts.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var ins = de.tblinsurances.Where(a => a.loginid == logid).ToList();
            return View(ins.ToPagedList(page, 10));
        }
        public ActionResult listInsurancedetails(int? id)
        {
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.dist = de.tbldistricts.ToList();
            var details = de.tblinsurances.Find(id);
            return View(details);
        }
        public ActionResult editInsurancedetails(int? id)
        {
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            var detail = de.tblinsurances.Find(id);
            return View(detail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult editInsurancedetails(tblinsurance ins)
        {
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.vereg = de.tblvehicleregs.ToList();
            tblinsurance insu = de.tblinsurances.Find(ins.insuranceid);
            insu.regid = ins.regid;
            insu.amount = ins.amount;
            insu.renewdate = ins.renewdate;
            de.SaveChanges();
            return RedirectToAction("listInsurance");
        }
        public ActionResult insurancename()
        {
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.dist = de.tbldistricts.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var insusername = de.tbllogins.Where(a => a.loginid == logid).ToList();
            ViewBag.username = insusername[0].username;
            return View();
        }
        public ActionResult insurancemailid()
        {
            ViewBag.cit = de.tblcities.ToList();
            ViewBag.dist = de.tbldistricts.ToList();
            int logid = Convert.ToInt32(Session["logid"]);
            var insmailid = de.tblregs.Where(a => a.loginid == logid).ToList();
            ViewBag.mailid = insmailid[0].email;
            return View();
        }
        public ActionResult InsuranceHome()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a => a.districtname).ToList();
            var vehcount = de.tblvehicleregs.ToList();
            TempData["vehcountreg"] = vehcount.Count;
            var inscount = de.tblinsurances.ToList();
            TempData["inscountreg"] = inscount.Count;
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