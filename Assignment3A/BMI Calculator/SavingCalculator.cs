using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class SavingCalculator
    {
        //instance variables for input        
        private double initialBal = 0.0;
        private double monthlyDep = 0.0;
        private double period = 0.0;
        private double growth = 0.0;
        private double fees = 0.0;
       
        //setters and getters - variables that give access 
        public double GetInitialBalance()
        {            
            return initialBal;
        }
        public void SetInitialBalance(double initialBal)
        {
            if (initialBal >= 0.0)
                this.initialBal = initialBal;
        }
        public double GetMonthlyDeposit()
        {            
            return monthlyDep;
        }
        public void SetMonthlyDeposit(double monthlyDep)
        {
            if (monthlyDep >= 0.0)
                this.monthlyDep = monthlyDep;
        }
        public double GetPeriod()
        {
            return period;
        }
        public void SetPeriod(double period)
        {
            if (period >= 0.0)
                this.period = period;
        }
        public double GetGrowth()
        {
            return growth;
        }
        public void SetGrowth(double growth)
        {
            if (growth >= 0.0)
                this.growth = growth;
        }
        public double GetFees()
        {
            return fees;
        }
        public void SetFees(double fees)
        {
            if (fees >= 0.0)
                this.fees = fees;
        }
        public double CalculateAmountPaid()
        {
            double amtPaid = 0.0;
            amtPaid = (monthlyDep * period * 12.0) + initialBal;
            return amtPaid;
        }
        //10% interest rate per year
        //monthlyIntRate = (10 / 100) / 12;
        //balance += intEarned + monthlyDep + initialBal;
        //intEarned = monthlyIntRate* balance + 1;
        public double CalculateAmountEarned()
        {
            double amtEarned = 0.0;            
            double body = (1.0 + (growth / 12.0)); //(1 + r/n)
            double exponent = 12.0 * period; //nt = times per year * years
            
            amtEarned = CalculateAmountPaid() + ((monthlyDep * 12.0 * body) * Math.Pow(body, exponent)); //P(1+r/n)^nt
            return amtEarned;
        }
        public double CalculateFinalBalance()
        {            
            double finBal = 0.0;
            
            finBal = CalculateAmountPaid() + CalculateAmountEarned() - CalculateTotalFees(); 
            return finBal;
        }
        // 1% fees in procent, 0.01 in decimal
        public double CalculateTotalFees()
        {            
            double totFees = 0.0;
            double inc = (1.0 + fees); //(1 + r/n), total fees rate per year            

            totFees =( monthlyDep * period * inc) * Math.Pow(inc, period); //P(1+r/n)^nt           
            return totFees;
        }
    }    
}
