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



        // GET: Account
        /*public ActionResult Index()
        {
            return View();
        }*/

        /*[HttpPost]
        public ActionResult Account(int ID)
        {
            int BIO_ID = -1;
            using (var sqlConnection1 = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=MyDB;Trusted_Connection=True;MultipleActiveResultSets=true"))
            {
                using (var cmd = new SqlCommand()
                {
                    CommandText = "SELECT BIO_Id FROM dbo.UserBIO WHERE User_Id = @id",
                    CommandType = CommandType.Text,
                    Connection = sqlConnection1
                })
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                    sqlConnection1.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            BIO_ID = Int32.Parse(reader[0].ToString());
                            // get the rest of the columns you need the same way
                        }
                    }
                }

                using (var cmd = new SqlCommand()
                {
                    CommandText = "SELECT * FROM dbo.BIO WHERE BIO_Id = @id",
                    CommandType = CommandType.Text,
                    Connection = sqlConnection1
                })
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = BIO_ID;
                    sqlConnection1.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ViewBag.BIO = Int32.Parse(reader[0].ToString());
                            // get the rest of the columns you need the same way
                        }
                    }
                }


            }
            return View();
        }*/


        /*public ActionResult Index()
        {
            using (twinterContext db = new twinterContext())
            {
                return View(db.users.ToList());
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User account)
        {
            if (ModelState.IsValid)
            {
                using (twinterContext db = new twinterContext())
                {
                    db.users.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.User1 + " has successfully registered!";
            }
            return View();
        }

        // Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            using (twinterContext db = new twinterContext())
            {
                var usr = db.users.Where(u => u.email == user.email && u.password == user.password).FirstOrDefault();
                if (usr != null)
                {
                    Session["email"] = usr.email.ToString();
                    Session["password"] = usr.password.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "email and/or Password are wrong!");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["Id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }*/



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