using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator 
{
    //NO INTERACTION WITH THE USER
    //NO MESSAGE BOXES
    //calculate BMI
    //input - height, weight, unit
    //instance variables to receive input to calculate
    //output - instance variables or nethod return value
    public class BMICalculator : ICalculator<UnitTypes>
    {
        //instance variables for input
        private string name = "No Name";
        private double height = 0.0; //m, inches
        private double weight = 0.0; //kg, lbs        
        private UnitTypes unit;
        
        public string Name { get; set; }
        

        //methods
        //Constructors
        //default constructors (parameterless)

        public BMICalculator()
        {
            unit = UnitTypes.Metric;
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

        public UnitTypes GetUnit()
        { return unit; }
        public void SetUnit(UnitTypes value)
        {
            this.unit = value;
        }

        //calculations
        //Pounds and inches
        //Formula (Imperial units): 703 * weight(lb) / [height(in) * height(in)]
        //Calculate BMI by dividing weight in pounds (lbs) by height in inches
        //Example: Weight = 150 lbs, Height = 5'5 (65")
        //Calculations: 703 * 150 / (65 * 65)] = 24.96

        public double CalculateBMI()
        {
            //metric values
            //Height must be m or inches
            double bmiValue = 0.0;

            if (unit == UnitTypes.Imperial)
            {
                bmiValue = 703.0 * weight / (height * height);
            }

            if (unit == UnitTypes.Metric)
            {
                bmiValue = weight / (height * height);
            }
            return bmiValue;
        }

        /// <summary>
        /// Method that sets the weight category depending on the value of BMI.
        /// Notice that it call the method CalculateBMI before setting the categories.
        /// </summary>
        /// <returns>Weight category based on the BMI value.</returns>

        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;

            if (bmi < 18.5)
                stringout = "underweight";
            else if (bmi <= 24.9)
                stringout = "Normal weight";
            else if (bmi <= 29.9)
                stringout = "Overweight (Pre-obesity)";
            else if (bmi <= 34.9)
                stringout = "Overweight (Obesity class I)";
            else if (bmi <= 39.9)
                stringout = "Overweight (Obesity class II)";
            else if (bmi >= 40)
                stringout = "Overweight (Obesity class III)";
            return stringout;
        }

        public string BmiNormalWeight() // based on normal adult height and weight, not children
        {
            double height = GetHeight();
            string stringout = string.Empty;
            if (unit == UnitTypes.Imperial)
            {
                //height in inches
                if (height <= 58)
                    stringout = "Normal weight shoud be between 91 and 118 lbs";
                if (height == 59)
                    stringout = "Normal weight shoud be between 94 and 123 lbs";
                if (height == 60)
                    stringout = "Normal weight shoud be between 97 and 127 lbs";
                if (height == 61)
                    stringout = "Normal weight shoud be between 100 and 131 lbs";
                if (height == 62)
                    stringout = "Normal weight shoud be between 104 and 135 lbs";
                if (height == 63)
                    stringout = "Normal weight shoud be between 107 and 140 lbs";
                if (height == 64)
                    stringout = "Normal weight shoud be between 110 and 144 lbs";
                if (height == 65)
                    stringout = "Normal weight shoud be between 114 and 149 lbs";
                if (height == 66)
                    stringout = "Normal weight shoud be between 118 and 154 lbs";
                if (height == 67)
                    stringout = "Normal weight shoud be between 121 and 158 lbs";
                if (height == 68)
                    stringout = "Normal weight shoud be between 125 and 163 lbs";
                if (height == 69)
                    stringout = "Normal weight shoud be between 128 and 168 lbs";
                if (height == 70)
                    stringout = "Normal weight shoud be between 132 and 173 lbs";
                if (height == 71)
                    stringout = "Normal weight shoud be between 136 and 178 lbs";
                if (height == 72)
                    stringout = "Normal weight shoud be between 140 and 183 lbs";
                if (height == 73)
                    stringout = "Normal weight shoud be between 144 and 188 lbs";
                if (height == 74)
                    stringout = "Normal weight shoud be between 148 and 193 lbs";
                if (height == 75)
                    stringout = "Normal weight shoud be between 152 and 199 lbs";
                if (height >= 76)
                    stringout = "Normal weight shoud be between 156 and 204 lbs";
            }
            else
            {
                //height in meters
                if (height <= 1.47)
                    stringout = "Normal weight shoud be between 41 and 52 kg";
                else if (height <= 1.50)
                    stringout = "Normal weight shoud be between 43 and 54 kg";
                else if (height <= 1.52)
                    stringout = "Normal weight shoud be between 44 and 56 kg";
                else if (height <= 1.55)
                    stringout = "Normal weight shoud be between 45 and 57 kg";
                else if (height <= 1.57)
                    stringout = "Normal weight shoud be between 47 and 59 kg";
                else if (height <= 1.60)
                    stringout = "Normal weight shoud be between 49 and 61 kg";
                else if (height <= 1.63)
                    stringout = "Normal weight shoud be between 50 and 64 kg";
                else if (height <= 1.65)
                    stringout = "Normal weight shoud be between 52 and 65 kg";
                else if (height <= 1.68)
                    stringout = "Normal weight shoud be between 54 and 67 kg";
                else if (height <= 1.70)
                    stringout = "Normal weight shoud be between 55 and 69 kg";
                else if (height <= 1.72)
                    stringout = "Normal weight shoud be between 57 and 72 kg";
                else if (height <= 1.75)
                    stringout = "Normal weight shoud be between 58 and 73 kg";
                else if (height <= 1.78)
                    stringout = "Normal weight shoud be between 60 and 76 kg";
                else if (height <= 1.80)
                    stringout = "Normal weight shoud be between 62 and 78 kg";
                else if (height <= 1.83)
                    stringout = "Normal weight shoud be between 64 and 80 kg";
                else if (height <= 1.85)
                    stringout = "Normal weight shoud be between 65 and 83 kg";
                else if (height <= 1.88)
                    stringout = "Normal weight shoud be between 67 and 84 kg";
                else if (height <= 1.91)
                    stringout = "Normal weight shoud be between 69 and 87 kg";
                else if (height >= 1.92)
                    stringout = "Normal weight shoud be between 71 and 89 kg";
            }
            return stringout;
        }

        public void SetUnit(UnitTypes unit)
        {
            throw new NotImplementedException();
        }

        public UnitTypes GetUnit()
        {
            throw new NotImplementedException();
        }
    }
}

