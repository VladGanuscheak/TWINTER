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
    public class ProcessStatus
    {
        protected const char NEED_TO_DO = '0';
        protected const char IN_PROCESS = '1';
        protected const char DONE = '2';
    }
    public class Task : ProcessStatus
    {
        private String msg;
        private char state;
        Task()
        {
            msg = "";
            state = NEED_TO_DO;
        }
        public Task(String msg, char state = NEED_TO_DO)
        {
            this.msg = msg;
            this.state = state;
        }
        public String getMsg() { return msg; }
        public char getState() { return state; }
    }
    public class HomeController : Controller
    {
        twinterContext db = new twinterContext();
        public ActionResult Index()
        {
            ViewBag.USERS = db.users;
            ViewBag.TRANDINGS = db.trandings;
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
            ViewBag.WorkProcess = new List<Task>() {
                new Task("User registration", '1'),
                new Task("User login/logout", '1'),
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
                new Task("Testing", '1')
            };
            return View();
        }
    }
}