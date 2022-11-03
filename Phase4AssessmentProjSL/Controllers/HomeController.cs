using DALPhase4;
using Phase4AssessmentProjSL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phase4AssessmentProjSL.Controllers
{
    public class HomeController : Controller
    {
        UserMethods methods = null;
        CustLogMethods methods1 = null;

        public HomeController()
        {
            methods = new UserMethods();
            methods1 = new CustLogMethods();
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UsersInfo user)
        {
            UserInfo user1 = new UserInfo();
            user1.UserId = user.UserId;
            TempData["id"] = user.UserId;
            user1.Email = user.Email;
            user1.Password = user.Password;

            bool ans = methods.ValidateUser(user1);
            if (ans)
            {
                return RedirectToAction("CustLog");
            }
            else
            {
                return View();
            }
        }

        public ActionResult CustLog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CustLog(CustomerInfo cust)
        {
            CustLogInfo cust1 = new CustLogInfo();
            cust1.LogId = cust.LogId;
            cust1.CustName = cust.CustName;
            cust1.CustEmail = cust.CustEmail;
            cust1.LogStatus = cust.LogStatus;
            cust1.UserId = Convert.ToInt32(TempData["id"]);
            cust1.Description = cust.Description;
           
             bool ans = methods1.SaveCustloginfotest(cust1);
             if (ans)
             {
                 ViewBag.msg = "Complaint is Registered Succesfully";
                 return View();
             }
             else
             {
                 return RedirectToAction("Index");
             } 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}