using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05._03
{
    class Garage
    {
        List<Vehicle> list = new List<Vehicle>();
        public void List()
        {
            while (true)
            {
                Console.WriteLine("Выберите нужное вам действие:");
                Console.WriteLine("\t\t 1. Добавить в список велосипед;");
                Console.WriteLine("\t\t 2. Добавить в список машину;");
                Console.WriteLine("\t\t 3. Добавить в список грузовик;");
                Console.WriteLine("\t\t 4. Вывести все велосипеды из списка;");
                Console.WriteLine("\t\t 5. Вывести все машины из списка;");
                Console.WriteLine("\t\t 6. Вывести все грузовики из списка;");
                Console.WriteLine("\t\t 7. Выход;");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        list.Add(Bicycle.InPut());
                        break;
                    case "2":
                        list.Add(Car.InPut());
                        break;
                    case "3":
                        list.Add(Lorry.InPut());
                        break;
                    case "4":
                        list.Print();
                }
            }
        }
    }
}
    

