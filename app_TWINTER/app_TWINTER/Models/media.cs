using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using app_TWINTER.Global_Constraints; // Constants

namespace app_TWINTER.Models
{
    public class media
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int media_Id { get; set; }

        public Nullable<int> media_type { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(300, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        public string URL { get; set; }

        public media()
        {
            media_type = null;
            URL = "something.png";
        }
    }
}