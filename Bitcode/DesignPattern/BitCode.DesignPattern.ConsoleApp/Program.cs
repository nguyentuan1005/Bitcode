using System;

namespace BitCode.DesignPattern.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BitCode Design Patterns");

            (new DecoratorDemo()).Start();

            Console.ReadKey();
        }
    }
}
