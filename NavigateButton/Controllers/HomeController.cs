using NavigateButton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NavigateButton.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult FirstValue(string id)
        {
            TempData["Value"]=id;
            TempData.Keep("Value");
            return View();
        }

        public ActionResult ThankYou()
        {
            return View();
        }

        public ActionResult Index()
        {
            EmpDept emp = new EmpDept();
            emp.DeptName = "De1";
            emp.Fname = "Ram";
           
            return View(emp);
        }
    }
}