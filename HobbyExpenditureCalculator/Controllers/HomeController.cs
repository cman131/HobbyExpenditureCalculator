using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HobbyExpenditureCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Models.HomeViewModel());
        }

        public ActionResult Index( HobbyExpenditureCalculator.Models.HomeViewModel model )
        {
            return View(model);
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