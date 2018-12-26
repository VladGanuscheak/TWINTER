using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app_TWINTER.Models
{
    public class Trandings
    {
        [Key]
        public int Tranding_Id { get; set; }

        public int Twint_Id { get; set; }

        public string HashTag { get; set; }
    }
}