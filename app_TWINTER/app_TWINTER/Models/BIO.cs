using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app_TWINTER.Models
{
    public class BIO
    {
        [Key]
        public int BIO_Id { get; set; }

        public string Location { get; set; }

        public string Website { get; set; }

        public int DD { get; set; }

        public int MM { get; set; }

        public int YYYY { get; set; }

        public Nullable<int> privacy { get; set; }
    }
}