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
        public List<System.Dynamic.ExpandoObject> Results { get; set; }

        /*This should only be true if:
        -Age >= 59.5
        -First Home
        -Haven't owned a home in 2 years
        */
        public bool NoPenalty { get; set; }
        public double Income { get; set;}
        public int YearCount { get; set; }
//Constructor
        public HomeViewModel(double argsIncome)
        {
            this.Income = argsIncome;
            this.HobbiesList = new List<Hobbies>();
            this.LocationList = new List<LivingLocation>();
        }
//Methods
        public double MoneyLeftOverYearly( LivingLocation location )
        {
            return this.Income-((location.getTotalCost()-location.getTotalDeduction())/YearCount) ;
        }

        public int HobbiesConsumption( double expendableMoney, Hobbies hobby )
        {
            return Convert.ToInt32(expendableMoney/hobby.GetCost());
        }
    }
}