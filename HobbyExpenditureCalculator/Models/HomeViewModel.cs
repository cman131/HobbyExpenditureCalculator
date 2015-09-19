using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HobbyExpenditureCalculator.Models
{
    /// <summary>
    /// 
    /// ViewModel for the homepage
    /// 
    /// </summary>
    public class HomeViewModel
    {
//Variables
        public List<Hobbies> HobbiesList { get; set; }
        public List<LivingLocation> LocationList { get; set; }

        public double Income { get; set;}
//Constructor
        public HomeViewModel(double argsIncome)
        {
            this.Income = argsIncome;
            this.HobbiesList = new List<Hobbies>();


        }

    }
}