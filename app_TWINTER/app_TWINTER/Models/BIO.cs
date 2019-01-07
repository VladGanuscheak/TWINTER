using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using app_TWINTER.Global_Constraints; // constants


namespace app_TWINTER.Models
{
    public class BIO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BIO_Id { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(250, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        public string Location { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(250, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        public string Website { get; set; }

        public int DD { get; set; }

        public int MM { get; set; }

        public int YYYY { get; set; }

        public Nullable<int> privacy { get; set; }

        // using constructor we can define Default 
        // values for some attributes in the table
        public BIO()
        {
            Location = Website = "-";
            MM = DD = 1;
            YYYY = 1995;
            privacy = null;
        }
    }
}