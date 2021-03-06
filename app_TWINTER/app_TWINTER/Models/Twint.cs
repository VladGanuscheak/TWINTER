﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using app_TWINTER.Global_Constraints;

namespace app_TWINTER.Models
{
    public class Twint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Twint_Id { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(300, MinimumLength = 1, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        public string msg { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(250, MinimumLength = 1, ErrorMessage = Constants.TOO_LONG_DESCRIPTION)]
        public string Location { get; set; }

        public Nullable<int> media_Id { get; set; }

        public Nullable<int> poll_Id { get; set; }
        
        [Required]
        public Int16 TwintVisibility { get; set; }

        public Twint()
        {
            TwintVisibility = Constants.Public;

            media_Id = null;
            poll_Id = null;
        }
    }
}