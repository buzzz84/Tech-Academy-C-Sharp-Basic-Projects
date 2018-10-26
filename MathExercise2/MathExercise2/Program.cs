using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathNumbers mathAnswers = new MathNumbers();
            Console.WriteLine("When the MathNumbers input recieves an integer it will multiply by 4.");
            Console.WriteLine("The remainder of integer 28 times 4 is: " + mathAnswers.MathInput(28));
            Console.WriteLine("When the MathNumbers input recieves a decimal, it will multiply it by 11 and then round it to an integer.");
            Console.WriteLine("The decimal 4.44 * 11 and rounded to an integer is: " + mathAnswers.MathInput(4.44m));
            Console.WriteLine("When the MathNumbers input recieves a string, it will try to convert it to an integer, and then add 9, and simply return 9 if the conversion fails.");
            Console.WriteLine("The string 42 converted to an integer and added to 9 is: " + mathAnswers.MathInput("42"));
            Console.ReadLine();
        }
    }
}
