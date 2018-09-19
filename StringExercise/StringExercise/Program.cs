using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Rick";
            string lname = "James";
            string phone = "867-5309";
            fname = fname.ToUpper();
            Console.WriteLine("Hello, my first name is " + fname + " and my last name is " + lname + " and you can reach me at " + phone);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Rick James. ");
            sb.Append("I like to party with Charlie Murphy. ");
            sb.Append("He is one of my best friends ever.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
