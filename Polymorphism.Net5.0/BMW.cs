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
        private string brand = "BMW";
        public string Model { get; set; }

        //constructor
        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = Model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Brand " + brand + "HP: " + HP + " color: " + Color);
        }

        public void Repair()
        {
            Console.WriteLine("Tje BMW {0} was repaired", Model);
        }
    }
}
