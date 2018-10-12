using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab4.Models
{
    public class ContactViewModel
    {

        
        [Display(Name = "Contact Id")]
        public int ContactId { get; set; }

        [Display(Name = "Contact Number")]
        public String ContactNumber { get; set; }
        [Display(Name = "Type")]
        public String Type { get; set; }

        [Display(Name = "Person Id")]
        public int PersonId { get; set; } 
        }
}