using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Net5._0
{
    internal class Car
    {
        //properties
        public int HP { get; set; }
        public string Color { get; set; }

        //constructor
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        
    }
}
