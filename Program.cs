using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("Green", 6, 2500, 4);
            House house2 = new House("Gunmetal", 1200);
            House house3 = new House();

            //house1.DisplayHouseInfo();
            //house2.DisplayHouseInfo();
            //house3.DisplayHouseInfo();

            //house2.Paint("Burnt Sienna");

            //house2.DisplayHouseInfo();

            house2.Name = "The blue house";
            Console.WriteLine(house2.Name);
        }
    }
}
