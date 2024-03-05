using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05._03
{
    class Lorry:Vehicle
    {
        public double MaxCapacity { get; set; }
        public Lorry() { }
        public Lorry(double Price, double MaxSpeed, int Age, double MaxCapacity) : base(Price, MaxSpeed, Age)
        {
            this.MaxCapacity = MaxCapacity;
        }
        public static Lorry InPut()
        {
            Console.WriteLine($"Введите цену: ");
            double Price = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите максимальную скорость: ");
            double MaxSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите год: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите максимальную емкость: ");
            double MaxCapacity = double.Parse(Console.ReadLine());
            return new Lorry(Price, MaxSpeed, Age, MaxCapacity);
        }
        public override void Print()
        {
            Console.WriteLine($"Цена:{Price}\n Максимальная скорость:{MaxSpeed}\n  Год:{Age} \n Максимальная емкость:{MaxCapacity} ");
        }
    }
}
