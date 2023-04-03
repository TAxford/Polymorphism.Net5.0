using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Net5._0
{
    internal class BMW : Car
    {
        //property
        private string Brand = "BMW";
        public string Model { get; set; }

        //constructor
        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = Model;
        }
    }
}
