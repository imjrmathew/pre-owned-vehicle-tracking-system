using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PreOwnedVehicle.Models;
using System.Net.Mail;
using System.Net;

namespace PreOwnedVehicle.Controllers
{
    public class ManageUserController : Controller
    {
        preownedvehicleEntities de = new preownedvehicleEntities();
        // GET: ManageUser
        public ActionResult RTOcreate()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a=>a.districtname).ToList();
            return View();
        }
        public ActionResult PoliceCreate()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a => a.districtname).ToList();
            return View();
        }
        public ActionResult InsuranceCreate()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a => a.districtname).ToList();
            return View();
        }
        public ActionResult PollutionCreate()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a => a.districtname).ToList();
            return View();
        }
        public ActionResult ServiceCreate()
        {
            ViewBag.cit = de.tblcities.OrderBy(a => a.cityname).ToList();
            ViewBag.dist = de.tbldistricts.OrderBy(a => a.districtname).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult RTOcreate(tblreg re)
        {
            int model = de.tbllogins.Where(a => a.username == re.username).Count();
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            if (model == 0)
            {
                if (ModelState.IsValid)
                {
                    tbllogin log = new tbllogin();
                    log.username = re.username;
                    log.password = re.password;
                    log.roleid = 2;
                    log.isdeleted = false;
                    log.status = false;
                    de.tbllogins.Add(log);
                    de.SaveChanges();

                    re.loginid = de.tbllogins.Max(a => a.loginid);
                    de.tblregs.Add(re);
                    de.SaveChanges();
                }
            }
            else
            {
                TempData["dataalready"] = "RTO user is already registered";
               
            }
            return RedirectToAction("../Home/Index");
        }
        [HttpPost]
        public ActionResult PoliceCreate(tblreg re)
        {
            int model = de.tbllogins.Where(a => a.username == re.username).Count();
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            if (model == 0)
            {
                if (ModelState.IsValid)
                {
                    tbllogin log = new tbllogin();
                    log.username = re.username;
                    log.password = re.password;
                    log.roleid = 3;
                    log.isdeleted = false;
                    log.status = false;
                    de.tbllogins.Add(log);
                    de.SaveChanges();

                    re.loginid = de.tbllogins.Max(a => a.loginid);
                    de.tblregs.Add(re);
                    de.SaveChanges();
                }
            }
            else
            {
                TempData["dataalready"] = "Police user is already registered";
            }
            return RedirectToAction("../Home/Index");
        }
        [HttpPost]
        public ActionResult InsuranceCreate(tblreg re)
        {
            int model = de.tbllogins.Where(a => a.username == re.username).Count();
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            if (model == 0)
            {
                if (ModelState.IsValid)
                {
                    tbllogin log = new tbllogin();
                    log.username = re.username;
                    log.password = re.password;
                    log.roleid = 4;
                    log.isdeleted = false;
                    log.status = false;
                    de.tbllogins.Add(log);
                    de.SaveChanges();

                    re.loginid = de.tbllogins.Max(a => a.loginid);
                    de.tblregs.Add(re);
                    de.SaveChanges();
                }
            }
            else
            {
                TempData["dataalready"] = "Insurance user is already registered";
            }
            return RedirectToAction("../Home/Index");
        }
        [HttpPost]
        public ActionResult PollutionCreate(tblreg re)
        {
            int model = de.tbllogins.Where(a => a.username == re.username).Count();
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            if (model == 0)
            {
                if (ModelState.IsValid)
                {
                    tbllogin log = new tbllogin();
                    log.username = re.username;
                    log.password = re.password;
                    log.roleid = 5;
                    log.isdeleted = false;
                    log.status = false;
                    de.tbllogins.Add(log);
                    de.SaveChanges();

                    re.loginid = de.tbllogins.Max(a => a.loginid);
                    de.tblregs.Add(re);
                    de.SaveChanges();
                }
            }
            else
            {
                TempData["dataalready"] = "Pollution user is already registered";
            }
            return RedirectToAction("../Home/Index");
        }
        [HttpPost]
        public ActionResult ServiceCreate(tblreg re)
        {
            int model = de.tbllogins.Where(a => a.username == re.username).Count();
            ViewBag.dist = de.tbldistricts.ToList();
            ViewBag.cit = de.tblcities.ToList();
            if (model == 0)
            {
                if (ModelState.IsValid)
                {
                    tbllogin log = new tbllogin();
                    log.username = re.username;
                    log.password = re.password;
                    log.roleid = 6;
                    log.isdeleted = false;
                    log.status = false;
                    de.tbllogins.Add(log);
                    de.SaveChanges();

                    re.loginid = de.tbllogins.Max(a => a.loginid);
                    de.tblregs.Add(re);
                    de.SaveChanges();
                }
            }
            else
            {
                TempData["dataalready"] = "Service user is already registered";
            }
            return RedirectToAction("../Home/Index");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbllogin log)
        {
            ViewBag.message = "";
            var logdetails = de.tbllogins.Where(a => a.username == log.username && a.password == log.password && a.isdeleted == false && a.status==true).ToList();
            if (logdetails.Count > 0)
            {
                Session["logid"] = logdetails[0].loginid;
                if (logdetails[0].roleid == 1)
                {
                    return RedirectToAction("../Admin/AdminHome");
                }
                else if (logdetails[0].roleid == 2)
                {
                    return RedirectToAction("../VehicleReg/RTOhome");
                }
                else if (logdetails[0].roleid == 3)
                {
                    return RedirectToAction("../PoliceComplientReg/PoliceHome");
                }
                else if (logdetails[0].roleid == 4)
                {
                    return RedirectToAction("../InsuranceReg/InsuranceHome");
                }
                else if (logdetails[0].roleid == 5)
                {
                    return RedirectToAction("../PollutionReg/PollutionHome");
                }
                else if (logdetails[0].roleid == 6)
                {
                    return RedirectToAction("../ServiceReg/ServiceHome");
                }
            }
            else
            {
                TempData["dataalready"] = "Invalid Username or Password!";
               
            }
            return RedirectToAction("../Home/Index");
        }
        public ActionResult forgetpwd()
        {
           return View();
        }
        [HttpPost]
        public ActionResult forgetpwd(string usernam)
        {
            var p = de.tbllogins.Where(a => a.username == usernam).SingleOrDefault();
            var pas = p.password;
            var lid = p.loginid;
            var uname = p.username;
            var ma = de.tblregs.Where(a => a.loginid == lid).SingleOrDefault();
            var mai = ma.email;
            SendEmail(pas, mai,uname);
            return RedirectToAction("../Home/Index");
        }
        private void SendEmail(string password,string toemail,string username)
        {
            Guid activationCode = Guid.NewGuid();


            using (MailMessage mm = new MailMessage("amsimplythebestz@gmail.com", toemail))
            {
                mm.Subject = "Account Password";
                string body = "Hi "+ username + ", Your Password is:  " + password;
               
                mm.Body = body;
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("<MAILID>", "<PASSWORD>");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
            }

        }

    }
}
