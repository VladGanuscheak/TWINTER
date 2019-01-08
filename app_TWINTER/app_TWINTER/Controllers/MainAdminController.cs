using app_TWINTER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using app_TWINTER.Global_Constraints; // Constants

namespace app_TWINTER.Controllers
{
    public class MainAdminController : Controller
    {
        twinterContext db = new twinterContext();

        // GET: Admin
        public ActionResult Index()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            return View();
        }
        
        public ActionResult UserList()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.USERS = db.users;
            return View();
        }

        public ActionResult BIOList()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.BIOS = db.BIOs;
            return View();
        }

        public ActionResult MediaList()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.Media = db.medias;
            return View();
        }

        public ActionResult PollList()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.Polls = db.polls;
            return View();
        }

        public ActionResult Stats()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.STATS = db.stats;
            return View();
        }

        public ActionResult TrandingList()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.TRANDING = db.trandings;
            return View();
        }

        public ActionResult TwintList()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.TWINT = db.twints;
            return View();
        }

        public ActionResult UserBio()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.UserBIOList = db.userBIOs;
            return View();
        }

        public ActionResult UserTwint()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.UserTwintList = db.UserTwints;
            return View();
        }

        public ActionResult LikesList()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.LikesList = db.likes;
            return View();
        }

        public ActionResult FollowsList()
        {
            if (Session["Role"] == null || Int16.Parse(Session["Role"].ToString()) != Constants.main_administrator)
            {
                return RedirectToAction("PermissionError", "Special");
            }
            ViewBag.FollowsList = db.follows;
            return View();
        }
    }
}