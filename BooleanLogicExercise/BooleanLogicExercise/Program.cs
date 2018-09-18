using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int age = Convert.ToInt32(yourAge);
            Console.WriteLine("Have you ever had a DUI? Please respond \"true\" or \"false\"");
            object duiArrest = Console.ReadLine();
            bool yourDui = Convert.ToBoolean(duiArrest);
            Console.WriteLine("How many speeding tickets do you have?");
            string speedTickets = Console.ReadLine();
            int speedTix = Convert.ToInt32(speedTickets);
            Console.WriteLine("Do you qualify for Insurance?");
            bool qualified = (age > 15 && yourDui != true && speedTix <= 3);
            Console.WriteLine(qualified);
        }
    }
}
