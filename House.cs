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
        static private int avgHousePrice;

        public void Paint(string color)
        {
            this.color = color; //this.color is referring to the color variable after "private string" above
        }

        public string CurrentColor()
        {
            return color;
        }
        
    }
}
