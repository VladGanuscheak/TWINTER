using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app_TWINTER.Models;

using System.Data.SqlClient; // sql
using System.Data;
// Constraints:
using app_TWINTER.Global_Constraints;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace app_TWINTER.Controllers
{
    public class Task
    {
        private String msg;
        private Int16 state;
        Task()
        {
            msg = "";
            state = Constants.NEED_TO_DO;
        }
        public Task(String msg, Int16 state = Constants.NEED_TO_DO)
        {
            this.msg = msg;
            this.state = state;
        }
        public String getMsg() { return msg; }
        public Int16 getState() { return state; }
    }
    public class HomeController : Controller
    {
        twinterContext db = new twinterContext();
        public ActionResult Index(int ID = 1)
        {

            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.USERS = db.users;
            ViewBag.UserID = ID;
            ViewBag.TRANDINGS = db.trandings;
            // My Twints
            var TwintID = db.UserTwints.Where(UT => UT.User_Id == ID).Select(UT => UT.Twint_Id).ToList();
            List<Twint> MyTwints = new List<Twint>();
            foreach (var twId in TwintID) MyTwints.Add(db.twints.Where(t => t.Twint_Id == twId).FirstOrDefault());
            ViewBag.MyTwints = MyTwints;
            //
            ViewBag.BIO = db.BIOs;
            ViewBag.media = db.medias;
            ViewBag.poll = db.polls;
            ViewBag.Stats = db.stats;
            ViewBag.Twint = db.twints;
            ViewBag.UserBIO = db.userBIOs;
            return View();
        }

        public ActionResult About()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.WorkProcess = new List<Task>() {
                new Task("User registration", Constants.DONE),
                new Task("User login/logout", Constants.DONE),
                new Task("User should be able to tweet"),
                new Task("User should be able to follow other users"),
                new Task("User should see tweets from users he followed"),
            };
            ViewBag.Optional = new List<Task>() {
                new Task("User should be able to like tweets"),
                new Task("User should be able to retweet a tweet from other users"),
                new Task("User should receive an email notification when a person likes/retweets his tweets"),
                new Task("User should be able to bookmark/save tweets and there should be a dedicated page where user can see them"),
                new Task("Any other feature you'd like to add"),
                new Task("Testing", Constants.IN_PROCESS)
            };
            return View();
        }
    }
}