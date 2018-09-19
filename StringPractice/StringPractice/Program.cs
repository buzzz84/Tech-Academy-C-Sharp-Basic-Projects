using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "ryan";

            //string quote = "The man said, \"Hello\", Ryan. \n Hello on a new line. \n \t Hello on a tab";
            //string filename = @"C:\\Users\\Ryan";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //name = name.ToLower();

            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Ryan");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
