using System;
using System.Collections.Generic;
using System.Text;

namespace BitCode.DesignPattern.Decorator
{
    public class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
            _name = "Milk";
            _price = 0.19;
        }
    }
}
