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

        twinterContext db = new twinterContext();

        // GET: Account
        /*public ActionResult Index()
        {
            return View();
        }*/

        [HttpPost]
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
        }

        public ActionResult Account()
        {
            return View();
        }
    }
}