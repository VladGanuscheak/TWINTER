using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app_TWINTER.Global_Constraints;

namespace app_TWINTER.Controllers
{
    public class SpecialController : Controller
    {
        // GET: Special
        public FileContentResult TermsOfUse()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Files/";
            byte[] fileBytes = System.IO.File.ReadAllBytes(Constants.FILE_PATH_TERMS_OF_USE);
            string fileName = Constants.FILE_TERMS_OF_USE;
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public FileContentResult PrivacyPolicy()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Files/";
            byte[] fileBytes = System.IO.File.ReadAllBytes(Constants.FILE_PATH_PRIVACY_POLICY);
            string fileName = Constants.FILE_PRIVACY_POLICY;
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public ActionResult PermissionError()
        {
            return View();
        }
    }
}