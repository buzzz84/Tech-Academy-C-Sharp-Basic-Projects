using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            long favNum = Convert.ToInt32(favoriteNumber);
            long total = favNum * 50;
            Console.WriteLine("Your favorite number times 50 is: " + total);
            Console.ReadLine();

            Console.WriteLine("What is your second favorite number?");
            string secondNumber = Console.ReadLine();
            int secNum = Convert.ToInt32(secondNumber);
            int total = secNum + 25;
            Console.WriteLine("Your favorite number plus 25 is: " + total);
            Console.ReadLine();

            Console.WriteLine("How old are you?");
            string ageNumber = Console.ReadLine();
            double ageNum = Convert.ToInt32(ageNumber);
            double total = ageNum / 12.5;
            Console.WriteLine("Your age divided by 12.5: " + total);
            Console.ReadLine();

            Console.WriteLine("Input a number between 1 and 100");
            string inputNumber = Console.ReadLine();
            Console.WriteLine("Is your number you picked greater than 50?");
            int inputNum = Convert.ToInt32(inputNumber);
            bool trueORFalse = inputNum > 50;
            Console.Write(trueORFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Input a number between 50 and 200.");
            string numInp = Console.ReadLine();
            float numInput = Convert.ToInt32(numInp);
            float otherTotal = numInput / 7.0f;
            Console.WriteLine("Your age divided by 7: " + otherTotal);
            Console.ReadLine();
        }
    }
}
