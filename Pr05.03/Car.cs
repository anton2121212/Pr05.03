using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05._03
{
    class Car : Vehicle
    {
        public double Power { get; set; }
        public Car() { }
        public Car(double Price, double MaxSpeed, int Age, double Power) : base(Price, MaxSpeed, Age)
        {
            this.Power = Power;
        }
        public static Car InPut()
        {
            Console.WriteLine($"Введите цену: ");
            double Price = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите максимальную скорость: ");
            double MaxSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите год: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите мощность автомобиля: ");
            double Power = double.Parse(Console.ReadLine());
            return new Car(Price, MaxSpeed, Age, Power);
        }
        public override void Print()
        {
            Console.WriteLine($"Цена:{Price}\n Максимальная скорость:{MaxSpeed}\n  Год:{Age}  Мощность автомобиля{Power}");
        }
    }
}
