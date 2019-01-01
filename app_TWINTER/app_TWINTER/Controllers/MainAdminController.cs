using app_TWINTER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace app_TWINTER.Controllers
{
    public class MainAdminController : Controller
    {
        twinterContext db = new twinterContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserList()
        {
            ViewBag.USERS = db.users;
            return View();
        }
    }
}