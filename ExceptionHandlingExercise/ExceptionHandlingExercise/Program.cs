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
            int[] numberOne = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            Console.WriteLine("Pick a number to divide by:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < numberOne.Length; j++)
            {
                numberOne / numberTwo;
            }
        }
    }
}
