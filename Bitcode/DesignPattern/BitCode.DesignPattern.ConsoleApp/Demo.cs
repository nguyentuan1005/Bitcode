using System;
using System.Collections.Generic;
using System.Text;

namespace BitCode.DesignPattern.ConsoleApp
{
    public abstract class Demo : IDemo
    {
        public Demo(string demo)
        {
            Console.WriteLine($"{demo}:");
        }

        public abstract void Start();
    }
}
