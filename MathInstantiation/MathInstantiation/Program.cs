using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathInstantiation
{
    static class Program
    {
       
            public static void Main()
            {

                Numbers mult = new Numbers();

                Console.WriteLine("Input a number please.");
                int num1 = Int32.Parse(Console.ReadLine());

                
                mult.Multiply(num1, out int total);
                total = num1 * 2;
                Console.WriteLine(total);
                Console.ReadLine();
                
            //Overload
                Add(3, 4);

            }
            public static void Add(int FN, int SN)
            {
                Console.WriteLine("Sum = {0}", FN + SN);
            }
            public static void Add(int FN, int SN, int TN)
            {
                Console.WriteLine("Sum = {0}", FN + SN);
            }
            public static void Add(int FN, int SN, int TN, int FourthNum)
            {
                Console.WriteLine("Sum = {0}", FN + SN);
            }

        
    }
}
