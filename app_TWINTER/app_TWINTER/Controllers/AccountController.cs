using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using app_TWINTER.Models;

using System.Data.SqlClient; // sql
using System.Data;
using app_TWINTER.Global_Constraints;


namespace app_TWINTER.Controllers
{
    public class AccountController : Controller
    {
        //[HttpGet]
        /*public ActionResult Login()
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
                        return RedirectToAction("Index");
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
                return RedirectToAction("Index");
            }
        }*/

        //
        //
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User input)
        {
            if (ModelState.IsValid)
            {
                using (twinterContext db = new twinterContext())
                {
                    db.users.Add(input);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = input.User1 + " has been registered successfuly!";
            }
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            if (Session["User"] != null)
            {
                RedirectToAction("Logout", "Account");
            }
            return View();
        }

        public ActionResult Logout()
        {
            /*if (Session["User"] != null)
            {
                Session["User"] = null;
            }*/
            return View();
        }

        [HttpPost]
        public ActionResult closed()
        {
            Session.Clear();
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public ActionResult Login(User input)
        {
            if (Session["User"] != null) return RedirectToAction("Logout");
            using (twinterContext db = new twinterContext())
            {
                var usr = db.users.Where(u => u.email == input.email && u.password == input.password).FirstOrDefault();
                if (usr != null)
                {
                    Session["UserId"] = usr.User_Id.ToString();
                    Session["User"] = usr.User1.ToString();
                    Session["Role"] = usr.Role.ToString();
                    Session["Email"] = usr.email.ToString();
                    Session["Password"] = usr.password.ToString();

                    switch(Int16.Parse(Session["Role"].ToString()))
                    {
                        case Constants.main_administrator:
                            return RedirectToAction("Index", "MainAdmin");
                        case Constants.administrator:
                            break;
                        case Constants.moderator:
                            break;
                        default:
                            break;
                    }
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "The Email or/and the Password are wrong!");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
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