using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace app_TWINTER.Models
{
    public class poll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int poll_Id { get; set; }
        
        public int Nvariants { get; set; }

        public int duration { get; set; }
    }
}