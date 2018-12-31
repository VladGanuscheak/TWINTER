using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
// Constraints:
using app_TWINTER.Global_Constraints;

namespace app_TWINTER.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        public string User1 { get; set; }

        public byte[] UPhoto { get; set; }

        public byte[] HeaderPhoto { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9!@#$%&*<>''-'\s]{12, 40}$", ErrorMessage = Constants.REGEX_ERROR)]
        [StringLength(50, MinimumLength = 12, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        public string password { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = Constants.INVALID_EMAIL)]
        [StringLength(90, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        public string email { get; set; }

        public char Role { get; set; }

        public User()
        {
            Role = Constants.ordinary_user;  
        }
    }
}