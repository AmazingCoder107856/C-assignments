using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public interface ICalculator<EnumType>
    {
        string GetName();
        void SetName(string name);
        double GetHeight();
        void SetHeight(double height);
        double GetWeight();
        void SetWeight(double weight);        
        void SetUnit(EnumType unit);
        EnumType GetUnit();
    }  
}
