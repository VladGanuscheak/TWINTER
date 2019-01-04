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

        public ActionResult BIOList()
        {
            ViewBag.BIOS = db.BIOs;
            return View();
        }

        public ActionResult MediaList()
        {
            ViewBag.Media = db.medias;
            return View();
        }

        public ActionResult PollList()
        {
            ViewBag.Polls = db.polls;
            return View();
        }

        public ActionResult Stats()
        {
            ViewBag.STATS = db.polls;
            return View();
        }

        public ActionResult TrandingList()
        {
            ViewBag.TRANDING = db.trandings;
            return View();
        }

        public ActionResult TwintList()
        {
            ViewBag.TWINT = db.twints;
            return View();
        }

        public ActionResult UserBio()
        {
            ViewBag.UserBIOList = db.userBIOs;
            return View();
        }

        public ActionResult UserTwint()
        {
            ViewBag.UserTwintList = db.UserTwints;
            return View();
        }
    }
}