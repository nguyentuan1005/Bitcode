using System;
using System.Collections.Generic;
using System.Text;

namespace BitCode.DesignPattern.Decorator
{
    public class Espresso : IBeverage
    {
        public double GetCost()
        {
            return 5;
        }

        public string GetDescription()
        {
            return "Espresso";
        }
    }
}
