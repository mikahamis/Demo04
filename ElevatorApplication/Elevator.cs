using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Elevator
    {
        private readonly int minFloor = 1;
        private readonly int maxFloor = 5;
        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor && value >= minFloor) floor = value;
                else
                {
                    Console.WriteLine("Floors between 1 and 5 only! ");
                }
                if (value == 0)
                {
                    Console.WriteLine("You become frustrated and decide the stairs are better for your calves anyway.");
                }            
            }
        }
        public void DefaultFloor()
        {
            
        }
    }
}
