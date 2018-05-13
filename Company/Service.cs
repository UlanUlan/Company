using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Company
{
    public struct Service
    {
        public List<Employees> emp;
        private Random rand;
        public void GenerateEmployee()
        {
            emp = new List<Employees>();
            rand = new Random();
            string[] editions = { "Maggie", "Penny", "Saya", "Princess",
                                  "Abby", "Laila", "Sadie", "Olivia",
                                  "Starlight", "Talla" };
            for (int i = 0; i < rand.Next(1, 30); i++)
            {
                Employees employe = new Employees();
                employe.FullName = editions[rand.Next(editions.Length)];
                employe.StartDate = DateTime.Now.AddMonths((rand.Next(1, 60) * -1));
                employe.Salary = rand.Next(30000, 100000) / rand.Next(1, 100);
                employe.Position = (Vacancies)rand.Next(0, 3);
                emp.Add(employe);
            }
        }
            public void PrintInfo(List<Employees> emp)
        {
            if (emp != null)
                foreach (Employees item in emp)
                {
                    Console.WriteLine("{0} | {1} | {2} | {3}", item.FullName, item.Salary, item.Position, item.StartDate);
                }
        }
        public void Report1(Vacancies vac)
        {
            double summSal = 0;
            int ClerkCount = 0;
            foreach (Employees item in emp)
            {
                if (item.Position == Vacancies.Clerk)
                {
                    summSal += item.Salary;
                    ClerkCount++;
                }
            }
            summSal = summSal / ClerkCount;
            List<Employees> list = new List<Employees>();
            foreach (Employees item in emp)
            {
                if (item.Position == vac && item.Salary > summSal)
                {
                    list.Add(item);
                }
            }
            Console.WriteLine("{0}, зарплата которых больше средней зарплаты {1} всех {2} клерков", vac.ToString(), summSal, ClerkCount);
            list = list.OrderBy(o => o.FullName).ToList();
            PrintInfo(list);
        }
        public void Report2()
        {
            Employees boss = new Employees();
            foreach (Employees item in emp)
            {
                if (item.Position == Vacancies.Boss)
                    boss = item; break;
            }
            List<Employees> list = new List<Employees>();
            foreach (Employees item in emp)
            {
                if (item.StartDate < boss.StartDate)
                    list.Add(item);
            }
            Console.WriteLine("Информация обо всех сотрудниках, принятых на работу позже босса - {0} ({1})", boss.FullName, boss.StartDate);
            list = list.OrderBy(o => o.FullName).ToList();
            PrintInfo(list);
        }
    }
}
