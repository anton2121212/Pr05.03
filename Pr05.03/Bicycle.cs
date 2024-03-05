using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05._03
{
    class Bicycle:Vehicle
    {
        public  int Passen { get; set; }
        public Bicycle() { }
        public Bicycle(double Price, double MaxSpeed, int Age, int Passen) : base(Price, MaxSpeed, Age)
        {
            this.Passen = Passen;
        }
        public static Bicycle InPut()
        {
            Console.WriteLine($"Введите цену: ");
            double Price = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите максимальную скорость: ");
            double MaxSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите год: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество пассажиров: ");
            int Passen = Convert.ToInt32(Console.ReadLine());
            return new Bicycle(Price, MaxSpeed, Age, Passen);
        }

        public override void Print()
        {
            Console.WriteLine($"Цена:{Price}\n Максимальная скорость:{MaxSpeed}\n  Год:{Age}  Количество пассажиров:{Passen}"); 
        }
    }
}
