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

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        public string User1 { get; set; }

        public byte[] UPhoto { get; set; }

        public byte[] HeaderPhoto { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 12, ErrorMessage = Constants.WRONG_SIZE)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        //[EmailAddress(ErrorMessage = Constants.INVALID_EMAIL)]
        [StringLength(90, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        public Int16 Role { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Compare("password", ErrorMessage = Constants.PASSWORDS_CONFIRMATION_FAULT)]
        [DataType(DataType.Password)]
        public string confirm_password { get; set; }

        public User()
        {
            Role = Constants.ordinary_user;
        }
    }
}