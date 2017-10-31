using System;
using System.Collections.Generic;
using System.Text;

namespace BitCode.DesignPattern.Decorator
{
    public class Filtered : IBeverage
    {
        public double GetCost()
        {
            return 7;
        }

        public string GetDescription()
        {
            return "Filtered";
        }
    }
}
