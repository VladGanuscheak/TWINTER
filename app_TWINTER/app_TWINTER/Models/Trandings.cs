using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data;
using System.Threading;
using app_TWINTER.Global_Constraints; // Constants

namespace app_TWINTER.Models
{
    public class Trandings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Tranding_Id { get; set; }
        
        public int Twint_Id { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(80, MinimumLength = 1)]
        public string HashTag { get; set; }
    }
}