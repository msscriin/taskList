using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace taskList.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Test = 1;

            return View();
        }
    }
}