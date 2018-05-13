using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Service ser = new Service();
            ser.GenerateEmployee();
            ser.PrintInfo(ser.emp);
            ser.Report1(Vacancies.Manager);
            Console.WriteLine("\n");
            ser.Report2();

            //Cat c = new Cat();
            //Console.WriteLine("Уровень сытости: " + c.levelOfSatiety);
            //Console.WriteLine("Съел рыбkу");
            //c.eatSomething(Food.Fish);
            //Console.WriteLine("Уровень сытости: " + c.levelOfSatiety);
            //Console.WriteLine("Съел мышку");
            //c.eatSomething(Food.Mouse);
            //Console.WriteLine("Уровень сытости: " + c.levelOfSatiety);
            //Console.WriteLine("Съел птичку");
            //c.eatSomething(Food.Bird);
            //Console.WriteLine("Уровень сытости: " + c.levelOfSatiety);




        }
    }
}
