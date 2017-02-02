using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            int number = 0;
            do
            {
                Console.WriteLine("Choose floor destination (1-5)");
                string line = Console.ReadLine();
                number = int.Parse(line);
                elevator.Floor = number;
                Console.WriteLine("The current floor is: " + elevator.Floor);

            } while (number != 0);                                                                        
        }
    }
}
