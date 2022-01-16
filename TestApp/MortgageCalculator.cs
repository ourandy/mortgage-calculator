using System;

namespace MortgageCalculator
{
    class MortgageCalculator
    {
        public static double calculatePeriodPayment(double principal,
            double annualInterest, double totalYears, double paymentsPerYear)
        {

            double monthlyInterest = annualInterest / paymentsPerYear;
            double numberOfPayments = totalYears * paymentsPerYear;

            double monthlyPayment = (principal * monthlyInterest *
                Math.Pow(1 + monthlyInterest, numberOfPayments)) / (
                Math.Pow(1 + monthlyInterest, numberOfPayments) - 1
                );

            return monthlyPayment;

        }

    }

}