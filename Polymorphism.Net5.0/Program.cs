using System;
using System.Collections.Generic;

namespace Polymorphism.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };
        }
    }
}
