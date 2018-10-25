using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            bool valid = false;

            while (!valid)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number != 0) 
                        valid = true;
                    int result1 = Math.multiplyByTwo(number);
                    int result2 = Math.ThirteenMinus(number);
                    int result3 = Math.square(number);
                    Console.WriteLine("Your number times 2 is " + result1);
                    Console.WriteLine("Your number minus 13 is " + result2);
                    Console.WriteLine("Your number squared is " + result3);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Try again!");
                }
            }
            Console.ReadLine();
        }
    }
}
