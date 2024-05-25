using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;

namespace SchoolDemoSystem.Models
{
    public class StudentDbModel
    {
      public Int32 StudentID { get; set; }
      [Required(ErrorMessage ="The field is required")]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }

      [Required(ErrorMessage ="The Field is required.")]
      [Display(Name ="Date of Birth")]
      public DateTime  DateOfBirth { get; set; }

    [Required(ErrorMessage ="The field is required.")]
    [Display(Name ="Gender")]
      public string  Gender { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Address")]
        public string  Address { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Country")]
        public Int32  Country { get; set;}

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "State")]
        public Int32  State { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "City")]
        public Int32 City { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Contact")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Email")]
        public string  Email { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Photo")]
        public string  Photo { get; set; }

    }
}