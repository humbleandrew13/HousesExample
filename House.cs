using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class House
    {
        private string color;
        private int rooms;
        private int size;
        private int doors;

        public House(string color, int rooms, int size, int doors)  //constructor
        {
            this.color = color;
            this.rooms = rooms;
            this.size = size;
            this.doors = doors;
        }

        public void Paint(string color)
        {
            this.color = color; //this.color is referring to the color variable after "private string" above
        }

        public string CurrentColor()
        {
            return color;
        }

        public void DisplayHouseInfo()
        {
            Console.Write("House Color: {0}, Rooms: {1}, ", color, rooms);
            Console.WriteLine("Size is {0} sq ft, with {1} doors", size, doors);
        }
    }
}
