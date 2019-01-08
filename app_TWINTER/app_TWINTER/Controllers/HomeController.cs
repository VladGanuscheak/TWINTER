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
        public ActionResult Index()
        {
            ViewBag.USERS = db.users;
            //
            /*string sqlString = "SELECT DISTINCT HashTag " +
                               "FROM db.Trandings AS tr " +
                               "GROUP BY tr.HashTag ";

            ViewBag.TRANDINGS = db.Database.SqlQuery<string>(sqlString, db.trandings).ToList();*/

            /*IObjectContextAdapter ctx = null;
            var objctx = (ctx as IObjectContextAdapter).ObjectContext;

            ViewBag.TRANDINGS = objctx.CreateQuery<Trandings>(sqlString).ToList();*/
            //
            //ViewBag.TRANDINGS = db.trandings.GroupBy(tr => tr.HashTag).OrderBy(db.trandings.)
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
                new Task("User registration", Constants.IN_PROCESS),
                new Task("User login/logout", Constants.IN_PROCESS),
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