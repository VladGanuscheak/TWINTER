using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace app_TWINTER.Models
{
    public class UserBIO
    {
        [Key]
        [Column(Order = 0)]
        public int User_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public int BIO_Id { get; set; }
    }
}