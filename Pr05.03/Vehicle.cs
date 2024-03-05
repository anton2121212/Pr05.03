using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05._03
{
    abstract class Vehicle
    {
        public double Price { get; set; }
        public double MaxSpeed { get; set; }
        public int Age { get; set; }
        
        public Vehicle() { }

        public Vehicle (double Price, double MaxSpeed, int Age)
        {
            this.Price = Price;
            this.MaxSpeed = MaxSpeed;
            this.Age = Age;
        }

        abstract public void Print();


    }
}
