using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data;
using System.Threading;

namespace app_TWINTER.Models
{
    public class Trandings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Tranding_Id { get; set; }
        
        public int Twint_Id { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 1)]
        public string HashTag { get; set; }
    }
}