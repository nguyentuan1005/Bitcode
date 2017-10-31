using System;
using System.Collections.Generic;
using System.Text;

namespace BitCode.DesignPattern.Decorator
{
    public abstract class CondimentDecorator: IBeverage
    {
        IBeverage _beverage;

        protected string _name = "undefined condiment";
        protected double _price = 0.0;

        public CondimentDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public double GetCost()
        {
            return _beverage.GetCost() + _price;
        }

        public string GetDescription()
        {
            return $"{_beverage.GetDescription()} + {_name}";
        }
    }
}
