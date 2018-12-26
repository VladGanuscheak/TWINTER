using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app_TWINTER.Models
{
    public class media
    {
        [Key]
        public int media_Id { get; set; }

        public Nullable<int> media_type { get; set; }

        public string URL { get; set; }
    }
}