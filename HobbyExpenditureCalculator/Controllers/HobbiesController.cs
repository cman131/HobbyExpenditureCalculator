using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HobbyExpenditureCalculator.Controllers
{
    public class HobbiesController : Controller
    {
        // GET: Hobbies
        public ActionResult Index()
        {
            return View();
        }
    }
}