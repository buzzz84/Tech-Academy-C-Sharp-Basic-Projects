using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numberOne = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
                Console.WriteLine("Pick a number to divide by:");
                int numberTwo = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < numberOne.Length; j++)
                {
                    int numberThree = numberOne[j] / numberTwo;
                    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                    Console.Read();
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Please use only numbers.");
            }
            Console.ReadLine();
            
        }
    }
}
