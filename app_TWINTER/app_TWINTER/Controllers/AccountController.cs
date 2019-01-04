using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using app_TWINTER.Models;

using System.Data.SqlClient; // sql
using System.Data;

namespace app_TWINTER.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User input)
        {
            if (ModelState.IsValid)
            {
                using (twinterContext db = new twinterContext())
                {
                    var obj = db.users.Where(a => a.email.Equals(input.email) && a.password.Equals(input.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["user"] = obj.User1.ToString();
                        Session["email"] = obj.email.ToString();
                        Session["password"] = obj.password.ToString();
                        Session["role"] = obj.Role.ToString();
                        return RedirectToAction("LoggedIn");
                    }
                }
            }
            return View(input);
        }

        public ActionResult LoggedIn()
        {
            if (Session["user"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}