using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperators2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your Hourly Rate?");
            string hourlyRate = Console.ReadLine();
            Console.WriteLine("How many Hours do you work per week?");
            string hoursWeek = Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("How many Hours do you work per week?");
            string hoursWeek2 = Console.ReadLine();
            long hourlyPay = Convert.ToInt32(hourlyRate);
            long hourlyWeek = Convert.ToInt32(hoursWeek);
            long total = hourlyPay * hourlyWeek;
            Console.WriteLine("Weekly salary of Person 1: " + total);
            long hourlyPay2 = Convert.ToInt32(hourlyRate2);
            long hourlyWeek2 = Convert.ToInt32(hoursWeek2);
            long total2 = hourlyPay2 * hourlyWeek2;
            Console.WriteLine("Weekly salary of Person 2: " + total2);
            int weeklySalary = Convert.ToInt32(total);
            int weeklySalary2 = Convert.ToInt32(total2);
            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool trueORFalse = total > total2;
            Console.Write(trueORFalse.ToString());
            Console.ReadLine();

        }
    }
}
