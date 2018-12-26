using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app_TWINTER.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }

        public string User1 { get; set; }

        public byte[] UPhoto { get; set; }

        public byte[] HeaderPhoto { get; set; }
    }
}