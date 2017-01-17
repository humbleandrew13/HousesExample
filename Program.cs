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
            House house1 = new House("Green", 4, 1000, 3);

            //house1.Paint("Green");
            //house1.NumberOfRooms(5);
            //house1.SetSize(1500);
            //house1.NumberOfDoors(3);

            Console.WriteLine(house1.CurrentColor());

            Console.WriteLine("House one is: {0}", house1.CurrentColor());

            house1.Paint("White");
            Console.WriteLine(house1.CurrentColor());

            House house2 = new House();
            house2.Paint("Blue");

            Console.WriteLine("House one is: {0}", house1.CurrentColor());
            Console.WriteLine("House two is: {0}", house2.CurrentColor());

            house1.NumberOfRooms(5);
            house1.SetSize(1500);
            house1.NumberOfDoors(3);
        }
    }
}
