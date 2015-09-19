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
        public int YearCount { get; set; }
//Constructor
        public HomeViewModel(double argsIncome)
        {
            this.Income = argsIncome;
            this.HobbiesList = new List<Hobbies>();
            this.LocationList = new List<LivingLocation>();
        }
//Mehtods
        public double MoneySaved( LivingLocation location )
        {
            return 0.0; //To Do: Create a function to calculate how much money is saved
        }

        public int HobbiesConsumption( double expendableMoney, Hobbies hobby )
        {
            return 0; //To Do: Create a function to tell how many of one hobby you can consume now
        }



    }
}