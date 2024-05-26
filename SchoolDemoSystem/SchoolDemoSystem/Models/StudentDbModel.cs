using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Optimization;

namespace SchoolDemoSystem.Models
{
    public class StudentDbModel
    {

        public List<Country> CountriesList { get; set; }
        public List<State> StatesList { get; set; }
        public List<City> CitiesList { get; set; }


        public int selectcountrybyId_ { get; set; }
        public int selectstatebyId_ { get; set; }
        public int selectcitybyId_ { get; set; }


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
        public Int32  CountryId { get; set;}

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "Country")]
        public string CountryName { get; set; }



        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "State")]
        public Int32  StateId { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "State")]
        public string StateName { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "City")]
        public Int32 CityId { get; set; }


        [Required(ErrorMessage = "The field is required.")]
        [Display(Name = "City")]
        public string CityName { get; set; }

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

    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }

    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }

    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }

}