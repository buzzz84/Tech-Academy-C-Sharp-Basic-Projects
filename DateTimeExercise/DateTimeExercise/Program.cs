using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            DateTime numberToHour = DateTime.Now.AddHours(number);
            Console.WriteLine("If I convert the number you entered, " + number + ", into hours, it will be " + numberToHour + " then!");
            Console.ReadLine();

        }
    }
}
