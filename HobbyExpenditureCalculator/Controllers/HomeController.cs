using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HobbyExpenditureCalculator.Models;


namespace HobbyExpenditureCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.HomeViewModel());
        }

        [HttpPost]
        public ActionResult Index( HobbyExpenditureCalculator.Models.HomeViewModel model )
        {
            NameValueCollection location = Request.Form;
            if(Request.Form["LocationType"]=="Buy") {
                model.Location = new PurchaseLocation(Request.Form["name"], Request.Form["state"], Request.Form["city"], model.Income, model.YearCount, Convert.ToDouble(Request.Form["Loan"]), Convert.ToDouble(Request.Form["interest"]), Convert.ToDouble(Request.Form["downPayment"]), Convert.ToDouble(Request.Form["prate"]), Convert.ToDouble(Request.Form["localtax"]));
            }

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