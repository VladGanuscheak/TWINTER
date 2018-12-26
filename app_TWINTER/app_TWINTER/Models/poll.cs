using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app_TWINTER.Models
{
    public class poll
    {
        [Key]
        public int poll_Id { get; set; }

        public int Nvariants { get; set; }

        public int duration { get; set; }
    }
}