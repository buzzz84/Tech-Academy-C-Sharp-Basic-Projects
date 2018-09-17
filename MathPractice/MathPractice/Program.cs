using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Addition
            int num1 = 5;
            int num2 = 7;
    
            int total = num1 + num2;

            Console.WriteLine(total);
            Console.ReadLine();

            // Subtraction
            int num3 = 7;
            int num4 = 5;

            int difference = num3 - num4;

            Console.WriteLine(difference);
            Console.ReadLine();

            // Multiplication
            int num5 = 5;
            int num6 = 7;

            int product = num5 * num6;

            Console.WriteLine(product);
            Console.ReadLine();

            // Remainder/Modulus Operator
            int num7 = 7;
            int num8 = 5;

            int remainder = num7 % num8;

            Console.WriteLine(remainder);
            Console.ReadLine();

            // Is Number Odd or Even
            int number = 7;

            int remainder = num7 % 2;

            Console.WriteLine(remainder);
            Console.ReadLine();
            // Remainder is 1 = odd, Remainder is 0 = Even

            // Addition with Different Data Types

            int num9 = 7;
            float num10 = 5.5f;

            float total = num9 + num10;
            //OR int total = num1 + Convert.ToInt32(num2);
            Console.WriteLine(total);

            //Casting Down- Will not compute
            double num11 = 7.03230923;
            float num12 = 5.9f;

            float total = num11 + num12;

            Console.WriteLine(total);
            // Cannot implicitly convert type ‘double’ to ‘float’. Are you missing a cast?

            //Casting Down- Will Compute
            double num1 = 7.03230923;
            float num2 = 5.9f;

            double total = num1 + num2;

            Console.WriteLine(total);
            // A “float” is 32-bit and a “double” is 64-bit. In other words, a “float” is no more than 7 digits long, and a “double” is no more than 15-16 digits long. So a “double” is more precise.
            // When the compiler converts a “float” to a “double” without being told to, this is called an “implicit conversion.” 
            // If we wanted to go the other way and convert a “double” to a “float”, we would have to do an “explicit conversion” on the “double” value.

            // Casting Down- Will Compute
            double num1 = 7.03230923;
            float num2 = 5.9f;

            float total = (float)num1 + num2;

            Console.WriteLine(total);
            // There is no implicit conversion available from a “float” or “double” to a “decimal”. These conversions must be done “explicitly”.
            // This is due solely to the nature of floats and decimals, which are encoded very differently than other number data types.
            // For example, you can implicitly cast from integer data types like “int” to a “decimal” very easily:
            decimal num1 = 7.03230923m;
            int num2 = 5;

            decimal total = num1 + num2;

            Console.WriteLine(total);

            // OR

            decimal num1 = 7.03230923m;
            sbyte num2 = 5;

            decimal total = num1 + num2;

            Console.WriteLine(total);

            // Math Operations done as Strings
            string firstName = “Jennifer”;
            string lastName = “Augusta";

            Console.WriteLine(firstName + lastName);

            // OR

            string name = “Elena”;
            int number = 5;

            Console.WriteLine(name + number);
            // Addition is only "math" operation available to strings.



        }
    }
}
