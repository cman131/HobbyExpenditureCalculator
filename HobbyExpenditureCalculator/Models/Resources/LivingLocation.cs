
using System;
/**
* Represents a location to live in. It could be either a rental or a purchase.
*/
namespace HobbyExpenditureCalculator.Models
{
    public abstract class LivingLocation
    {
        protected string name;
        protected string state;
        protected string city;

        /*
         * Retrieves the total cost that would have to be paid to live in this
         *   housing unit for yearCount years with the given income
         */
        public abstract double getTotalCost(double income, int yearCount);
    }

    public class RentalLocation : LivingLocation
    {
        double rent;

        public RentalLocation(string name, string state, string city, double rent)
        {
            this.name = name;
            this.state = state;
            this.city = city;
            this.rent = rent;
        }

        /*
         * Retrieves the total rent for a year. This can also be expanded to
         *   consider factors such as security deposits, but for this application
         *   we will make the ideal assumption that the customer will treat the place
         *   well and receive their security deposit back when they finish renting.
         */
        public override double getTotalCost(double income, int yearCount)
        {
            return rent * 12 * yearCount;
        }
    }

    public class PurchaseLocation : LivingLocation
    {
        double loan;
        double interestRate;
        double downPayment;

        public PurchaseLocation(string name, string state, string city, double loan, double interestRate, double downPayment)
        {
            this.name = name;
            this.state = state;
            this.city = city;
            this.loan = loan;
            this.interestRate = interestRate;
            this.downPayment = downPayment;
        }

        /*
         * Retrieves the total amount of money paid into their mortgage over yearCount years.
         * This method makes the assumption that the customer has the intention of paying off their loan in the given time.
         */
        public override double getTotalCost(double income, int yearCount)
        {
            double monthly = (this.loan-this.downPayment) * (this.interestRate * Math.Pow(1 + this.interestRate, yearCount * 12)) / (Math.Pow(1 + this.interestRate, yearCount * 12) - 1);
            return monthly * 12 * yearCount + this.downPayment;
        }
    }

}