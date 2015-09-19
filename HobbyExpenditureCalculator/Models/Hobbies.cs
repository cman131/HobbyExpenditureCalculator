using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*
Author: Peter Kang
Description: Hobby information
*/
namespace HobbyExpenditureCalculator.Models
{
    public class Hobbies
    {
        //Variables
        private double costPerConsumption { get; set;}
        public string name { get; set; }
        //Constructors

        /// <summary>
        /// empty constructor
        /// </summary>
        public Hobbies() { }

        public Hobbies(string argsName, int argsCost)
        {
            this.name = argsName;
            this.costPerConsumption = argsCost; 
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="other"></param>
        public Hobbies(Hobbies other)
        {
            this.setCost(other.GetCost());
            this.setName(other.GetName());
        }

        //Get

        /// <summary>
        /// Get function for the cost
        /// </summary>
        /// <returns> the cost as a double </returns>
        public double GetCost()
        {
            return this.costPerConsumption;
        }

        /// <summary>
        /// Get function for the name of the hobbie
        /// </summary>
        /// <returns> the name of the hobbies as a string </returns>
        public string GetName()
        {
            return this.Name;
        }

        /// <summary>
        /// Set function for the name of the hobby
        /// </summary>
        /// <param name="argsName"> sets the name of the hobby </param>
        public void setName(string argsName)
        {
            this.name = argsName;
        }

        /// <summary>
        /// Set function for the name of the hobby
        /// </summary>
        /// <param name="argsCost"> the new name of the hobby </param>
        public void setCost(double argsCost)
        {
            this.costPerConsumption = argsCost;
        }

        /// <summary>
        /// Formatts the cost
        /// </summary>
        /// <returns> returns a string and formatts the double </returns>
        public string getCostAsString()
        {
            return String.Format("{0:C}", Convert.ToInt32(this.GetCost()));
        }
    }
}