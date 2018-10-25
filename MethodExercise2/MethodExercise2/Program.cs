using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Info Option = new Info();

            Console.WriteLine("Please type in a number.");
            int num1 = Int32.Parse(Console.ReadLine());
            int userInput = num1;
            Console.WriteLine("**OPTIONAL** \n You may pick another number unless you would like number already assigned.");
            int num2 = 15;
            string standardInput = Console.ReadLine();

            if (string.IsNullOrEmpty(standardInput))
            {
                Console.WriteLine(Info.Numbers(userInput, Convert.ToInt32(num2)));
            }
            else
            {
                Console.WriteLine(Info.Numbers(userInput, Convert.ToInt32(standardInput)));
            }

            Console.ReadLine();
        }
    }
}
