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
            ViewBag.UserNameCurrent = db.users.Where(u => u.User_Id == ID).Select(u => u.User1).FirstOrDefault();
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

        public ActionResult DoTwint()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();//View(new Twint());
        }

        [HttpPost]
        public ActionResult DoTwint(Twint input)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (ModelState.IsValid)
            {
                //
                db.twints.Add(input);
                db.SaveChanges();
                var LastTwintId = db.twints.Select(t => t.Twint_Id).Max();
                db.UserTwints.Add(new UserTwint { User_Id = Int32.Parse(Session["UserId"].ToString()), Twint_Id = LastTwintId });
                db.SaveChanges();
                //
                ModelState.Clear();
                //
                return RedirectToAction("Index/" + Session["UserId"].ToString(), "Home");
            }
            return View();
        }

        // Need to test last two functionalities!

        public ActionResult Follow(int ID = 1)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (Int32.Parse(Session["UserId"].ToString()) == ID)
            {
                return RedirectToAction("Index/" + ID.ToString(), "Home");
            }

            int MyId = Int32.Parse(Session["UserId"].ToString());
            var Following = db.follows.Where(fo => fo.Follower == MyId && fo.Following == ID).Select(f => f.Follower);
            if (Following.Count() < 1)
            {
                db.follows.Add(new Follow { Follower = MyId, Following = ID });
                db.SaveChanges();
                ViewBag.UserFollowing = db.users.Where(u => u.User_Id == ID).Select(u => u.User1).FirstOrDefault();
                return View();
            }
            return RedirectToAction("Index/" + ID.ToString(), "Home");
        }

        public ActionResult Unfollow(int ID = 1)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (Int32.Parse(Session["UserId"].ToString()) == ID)
            {
                return RedirectToAction("Index/" + ID.ToString(), "Home");
            }

            int MyId = Int32.Parse(Session["UserId"].ToString());
            var Following = db.follows.Where(fo => fo.Follower == MyId && fo.Following == ID);

            if (Following.Count() > 0)
            {
                db.follows.Remove(Following.First());
                db.SaveChanges();
                ViewBag.UserUNFollowing = db.users.Where(u => u.User_Id == ID).Select(u => u.User1).FirstOrDefault();
                return View();
            }
            return RedirectToAction("Index/" + ID.ToString(), "Home");
        }

        public ActionResult Followers(int ID = 1)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var followersId = db.follows.Where(f => f.Following == ID).Select(fo => fo.Follower).ToList();
            List<string> tmp = new List<string>();
            foreach(var item in followersId)
            {
                tmp.Add(db.users.Where(u => u.User_Id == item).Select(u => u.User1).FirstOrDefault());
            }
            ViewBag.FOLLOWERS = tmp;
            return View();
        }
    }
}