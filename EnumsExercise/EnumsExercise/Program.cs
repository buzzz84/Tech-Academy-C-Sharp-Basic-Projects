using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsExercise
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Tell me what day of the week it is today.");
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                Console.WriteLine("Today must be " + day + " then.");
            }
            catch (Exception)
            {
                Console.WriteLine("That is not a day of the week.");
            }
            Console.ReadLine();
        }
        
    }
    
}
