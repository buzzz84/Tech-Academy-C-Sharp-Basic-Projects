using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //COMPARISON OPERATORS

            //bool trueORFalse = 12 > 5;
            //Console.Write(trueORFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 68;

            //bool isWarm = currentTemperature >= roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();


            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature == roomTemperature; // == is equal
            //Console.WriteLine(isWarm);
            //Console.ReadLine();


            int roomTemperature = 70;
            int currentTemperature = 70;

            bool isWarm = currentTemperature != roomTemperature; // != is not equal
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
