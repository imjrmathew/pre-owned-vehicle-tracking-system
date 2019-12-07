using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PreOwnedVehicle.Models;

namespace PreOwnedVehicle.Controllers
{
    public class HomeController : Controller
    {
        preownedvehicleEntities de = new preownedvehicleEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult feedback()
        {
            return View();
        }
        [HttpPost]
        public ActionResult feedback(tblfeedback fb)
        {
            de.tblfeedbacks.Add(fb);
            de.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult usersearch()
        {
            return View();
        }
        [HttpPost]
        public ActionResult userregdisplay(string vehicleid)
        {
            int model = de.tblvehicleregs.Where(a => a.vehicleid == vehicleid).Count();
            if(model>0)
            {
                var ids = de.tblvehicleregs.Where(a => a.vehicleid == vehicleid).SingleOrDefault();
                int id = ids.regid;
                ViewBag.vehicle = de.tblvehicleregs.Where(a => a.vehicleid == vehicleid).ToList();
                ViewBag.insurances = de.tblinsurances.Where(a => a.regid == id).ToList();
                ViewBag.services = de.tblservices.Where(a => a.regid == id).ToList();
                ViewBag.polices = de.tblpolicecomplaints.Where(a => a.regid == id).ToList();
                ViewBag.pollutions = de.tblpollutions.Where(a => a.regid == id).ToList();
                return View();
            }
            else
            {
                TempData["dataalready"] = "Inavlid match found!";
            }
            return RedirectToAction("Index","Home");
        }
    }
}