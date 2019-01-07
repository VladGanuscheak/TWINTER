using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using app_TWINTER.Global_Constraints; // Constants

namespace app_TWINTER.Models
{
    public class Stats
    {
        [Key]
        [Column(Order = 0)]
        public int poll_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public int order_Id { get; set; }

        public int result { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(100, MinimumLength = 1, ErrorMessage = Constants.TOO_SHORT_DESCRIPTION + " or " + Constants.TOO_LONG_DESCRIPTION)]
        public string variant { get; set; }

        public Stats()
        {
            result = 0; // Initially ZERO
            variant = "?";
        }
    }
}