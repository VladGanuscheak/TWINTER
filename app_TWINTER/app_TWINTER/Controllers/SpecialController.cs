using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app_TWINTER.Global_Constraints;

namespace app_TWINTER.Controllers
{
    public class SpecialController : Controller
    {
        // GET: Special
        public FilePathResult TermsOfUse()
        {
            // file path
            string file_path = Server.MapPath(Constants.FILE_PATH_TERMS_OF_USE);
            // file type
            string file_type = Constants.FILE_TYPE_PDF;
            // file name
            string file_name = Constants.FILE_TERMS_OF_USE;
            return File(file_path, file_type, file_name);
        }

        /*public FilePathResult PrivacyPolicy()
        {
            return;
        }*/

        public ActionResult PermissionError()
        {
            return View();
        }
    }
}