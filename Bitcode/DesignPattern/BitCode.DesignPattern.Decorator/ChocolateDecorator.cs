using System;
using System.Collections.Generic;
using System.Text;

namespace BitCode.DesignPattern.Decorator
{
    public class ChocolateDecorator : CondimentDecorator
    {
        public ChocolateDecorator(IBeverage beverage) : base(beverage)
        {
            _name = "Chocolate";
            _price = 0.29;
        }
    }
}
