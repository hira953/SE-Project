using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab4.Models
{
    public class PersonViewModel
    {
        [Required]
        [Display(Name = "PersonId")]
        public int PersonId { get; set; }
        [Required]
        [Display(Name = "FirstName")]
        public String FirstName { get; set; }
        [Required]
        [Display(Name = "MiddleName")]
        public String MiddleName { get; set; }
        [Required]
        [Display(Name = "LastName")]
        public String LastName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Added On")]
        public DateTime AddedOn { get; set; }
        [Required]
        [Display(Name = "Added By")]
        public String AddedBy { get; set; }
        [Required]
        [Display(Name = "Home Address")]
        public String HomeAddress { get; set; }
        [Required]
        [Display(Name = "Home City")]
        public String HomeCity { get; set; }
        //[RegularExpression(("[A-Z])\ w+")]
        [Display(Name = "Facebook Account Id")]
        public String FaceBookAccountId { get; set; }
        //[RegularExpression(("[A-Z])\ w+")]
        [Display(Name = "LinkedIn Id")]
        public String LinkedInId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Update On")]
        public DateTime UpdateOn { get; set; }

        [Required]
        [Display(Name = "Image Path")]
        public String ImagePath { get; set; }
        //[RegularExpression(("[A-Z])\ w+"))]
        [Display(Name = "Twitter Id")]
        public String TwitterId { get; set; }
        [Display(Name = "Email Id")]
        public String EmailId { get; set; }
    }
}