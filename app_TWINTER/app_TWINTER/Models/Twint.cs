using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app_TWINTER.Models
{
    public class Twint
    {
        [Key]
        public int Twint_Id { get; set; }

        public string msg { get; set; }

        public string Location { get; set; }

        public int media_Id { get; set; }

        public int poll_Id { get; set; }
    }
}