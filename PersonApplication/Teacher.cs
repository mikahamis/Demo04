using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        // default constructor
        public Teacher()
        {

        }

        // parametric constructor calls base calss constructor with parameters
        public Teacher(string firstName, string lastName, string room)
            : base(firstName,lastName)
        {
            Room = room;
        }

        // methods
        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        // override 
        public override string ToString()
        {
            // base on tässä tapauksessa Person-luokka
            // "eli" kutsutaan Person-luokan ToString()-metodia
            // return Firstname + " " + ... + Room;
            return base.ToString() + " " + Room;
        }
    }
}
