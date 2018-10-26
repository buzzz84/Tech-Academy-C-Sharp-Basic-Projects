using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: [{FirstName} {LastName}]");
        }
        public void Quit()
        {
            Console.WriteLine("I am quitting right now, I just won the MegaMillions!!!");
            Console.ReadLine();
        }
    }
}
