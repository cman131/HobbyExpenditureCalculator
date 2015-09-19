
using System;
/**
* Represents a location to live in. It could be either a rental or a purchase.
*/
namespace HobbyExpenditureCalculator.Models
{
    public abstract class LivingLocation
    {
        public string name { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public int yearCount { get; set; }
        public double income { get; set; }

        /*
         * Retrieves the total cost that would have to be paid to live in this
         *   housing unit for yearCount years with the given income
         */
        public abstract double getTotalCost();

        /*
         * Retrieves the total amount deducted from the individual's taxes relative to their home ownership
         */
        public abstract double getTotalDeduction();

        /*
         * Checks if the person can afford to live here on their current income
         */
        public abstract bool canAfford();
    }

    public class RentalLocation : LivingLocation
    {
        double rent { get; set; }

        public RentalLocation(string name, string state, string city, double income, int yearCount, double rent)
        {
            this.name = name;
            this.state = state;
            this.city = city;
            this.rent = rent;
            this.yearCount = yearCount;
            this.income = income;
        }

        /*
         * Retrieves the total rent for a year. This can also be expanded to
         *   consider factors such as security deposits, but for this application
         *   we will make the ideal assumption that the customer will treat the place
         *   well and receive their security deposit back when they finish renting.
         */
        public override double getTotalCost()
        {
            return rent * 12 * this.yearCount;
        }

        /*
         * This total is in relation to the purchase deductions
         */
        public override double getTotalDeduction()
        {
            return 0;
        }

        public override bool canAfford()
        {
            return this.income > this.rent * 12;
        }
    }

    public class PurchaseLocation : LivingLocation
    {
        public double loan { get; set; }
        public double interestRate { get; set; }
        public double downPayment { get; set; }
        public double totalDeductions { get; set; }
        public double premiumRate { get; set; }
        public double localPropertyTaxes { get; set; }

        public PurchaseLocation(string name, string state, string city, double income, int yearCount, double loan,
            double interestRate, double downPayment, double premiumRate, double localPropertyTaxes)
        {
            this.name = name;
            this.state = state;
            this.city = city;
            this.loan = loan;
            this.interestRate = interestRate;
            this.downPayment = downPayment;
            this.income = income;
            this.yearCount = yearCount;
            this.localPropertyTaxes = localPropertyTaxes;
        }

        /*
         * Retrieves the total amount of money paid into their mortgage over yearCount years.
         * This method makes the assumption that the customer has the intention of paying off their loan in the given time.
         */
        public override double getTotalCost()
        {
            double monthly = (this.loan-this.downPayment) * (this.interestRate *
                Math.Pow(1 +this.interestRate, this.yearCount * 12)) / (Math.Pow(1 + this.interestRate, this.yearCount * 12) - 1);
            return monthly * 12 * this.yearCount + this.downPayment + 12 * this.yearCount *
                this.premiumRate + 12 * this.yearCount * this.localPropertyTaxes;
        }
        
        public override double getTotalDeduction()
        {
            double mortgage = getTotalCost() - this.downPayment - this.loan;
            return this.downPayment + this.premiumRate * 12 * this.yearCount + this.localPropertyTaxes * 12 * this.yearCount;
        }

        public override bool canAfford()
        {
            return this.income > this.getTotalCost() / this.yearCount;
        }
    }

}