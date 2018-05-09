using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Cat
{
    public enum Food { Fish, Mouse, Bird }
    public struct Cat
    {
        public int levelOfSatiety { get; set; }
        public Food food { get; set; }
        public void eatSomething(Food food)
        {
            if (food == Food.Bird)
                levelOfSatiety += 3;
            else if (food == Food.Bird)
                levelOfSatiety += 2;
            else
                levelOfSatiety += 1;
        }
        public void showLevelOfSatiety()
        {
            Console.WriteLine("Уровень сытости кошки: {0}", levelOfSatiety);
        }
    }
}
