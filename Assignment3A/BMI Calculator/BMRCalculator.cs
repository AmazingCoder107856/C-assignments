using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public class BMRCalculator : ICalculator<UnitTypes>
    {        
        //instance variables for input
        private string name = "No Name";
        private double height = 0.0; //m, inches
        private double weight = 0.0; //kg, lbs
        private double age = 0.00;
        private UnitTypes unit;
        private GenderTypes gender;
        private ActivityTypes activity;

        public string Name { get; set; }

        private UnitTypes unit1;

        private UnitTypes GetUnit1()
        {
            return unit1;
        }

        private void SetUnit1(UnitTypes value)
        {
            unit1 = value;
        }

        GenderTypes Gender { get; set; }
        ActivityTypes Activity { get; set; }        

        //methods
        //Constructors
        //default constructors (parameterless)

        public BMRCalculator()
        {
            unit = UnitTypes.Metric;
            gender = GenderTypes.Female;
            activity = ActivityTypes.Sedentary;
        }        

        //setters and getters - variables that give access 
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            if (height >= 0.0)
                this.height = height;
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double weight)
        {
            if (weight >= 0.0)
                this.weight = weight;
        }
        public double GetAge()
        {
            return age;
        }
        public void SetAge(double age)
        {
            this.age = age;
        }

        public UnitTypes Unit { get { return unit; } set => this.unit = value; }
        public GenderTypes Gender { get { return unit; } set => this.unit = value; }

        public ActivityTypes GetActivity()
        {
            return activity;
        }

        public void SetActivity(ActivityTypes value)
        {
            this.activity = value;
        }

        //calculations
        //Pounds and inches
        //Formula (Imperial units): 703 * weight(lb) / [height(in) * height(in)]
        //Calculate BMI by dividing weight in pounds (lbs) by height in inches
        //Example: Weight = 150 lbs, Height = 5'5 (65")
        //Calculations: 703 * 150 / (65 * 65)] = 24.96        

        public double CalculateBMR()
        {
            //metric values
            //Height must be m or inches
            double bmrValue = 0.0;
            
            if (gender == GenderTypes.Female)
            {
                bmrValue = 10 * weight * 6.25 * height - 5 * age - 161.0;
                
            } 
            else if (gender == GenderTypes.Male)
            {
                bmrValue = 10 * weight * 6.25 * height - 5 * age + 5.0;                
            }
            return bmrValue;
        }
        public double CalculateCalToMaintain()
        {
            double toMaintain = 0.0;                       

            switch (activity)
            {
                case ActivityTypes.Sedentary:
                    toMaintain = CalculateBMR() * 1.20;
                    break;
                case ActivityTypes.LightlyActive:
                    toMaintain = CalculateBMR() * 1.375;
                    break;
                case ActivityTypes.ModeratelyActive:
                    toMaintain = CalculateBMR() * 1.550;
                    break;
                case ActivityTypes.VeryActive:
                    toMaintain = CalculateBMR() * 1.725;
                    break;
                case ActivityTypes.ExtraActive:
                    toMaintain = CalculateBMR() * 1.90;
                    break;
            }
            return toMaintain;
        }
        public double CalculateCalToLose1()
        {
            double toLose1 = 0.0;
            toLose1 = CalculateCalToMaintain() - 500.0;
            
            return toLose1;
        }
        public double CalculateCalToLose2()
        {
            double toLose2 = 0.0;
            toLose2 = CalculateCalToMaintain() - 1000.0;

            return toLose2;
        }
        public double CalculateCalToGain1()
        {
            double toGain1 = 0.0;
            toGain1 = CalculateCalToMaintain() + 500.0;

            return toGain1;
        }
        public double CalculateCalToGain2()
        {
            double toGain2 = 0.0;
            toGain2 = CalculateCalToMaintain() + 1000.0;

            return toGain2;
        }
               
    }
}
