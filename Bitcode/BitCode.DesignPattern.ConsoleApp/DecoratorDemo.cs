using System;
using System.Collections.Generic;
using System.Text;
using BitCode.DesignPattern.Decorator;

namespace BitCode.DesignPattern.ConsoleApp
{
    /// <summary>
    /// <see cref="https://assist-software.net/blog/implementation-decorator-pattern-c"/>
    /// </summary>
    public class DecoratorDemo : Demo
    {
        public DecoratorDemo() : base("Decorator pattern")
        {
        }

        public override void Start()
        {
            var beverages = new List<IBeverage>
            {
                new Espresso(),
                new MilkDecorator(new Espresso()),
                new ChocolateDecorator(new MilkDecorator(new Espresso())),
                new ChocolateDecorator(new MilkDecorator(new MilkDecorator(new Espresso())))
            };

            Console.WriteLine("Menu today:");
            foreach (var beverage in beverages)
            {
                Console.WriteLine($"  {beverage.GetDescription()}   {beverage.GetCost()}$");
            }
        }
    }
}
