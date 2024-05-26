using SchoolDemoSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolDemoSystem.Controllers
{
    public class HomeController : Controller
    {
        StudentDbContext db=new StudentDbContext();

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult CreateStudent()
        {
            StudentDbModel studentDb=new StudentDbModel();

            studentDb.CountriesList =db.GetCountryById();
            studentDb.StatesList = new List<State>();
            studentDb.CitiesList = new List<City>();

            studentDb.selectcountrybyId_ = 0;
            studentDb.selectstatebyId_ = 0;
            studentDb.selectcitybyId_ = 0;

            return View(studentDb);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}