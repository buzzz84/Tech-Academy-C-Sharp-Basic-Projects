using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter SW = new StreamWriter(@"C:\Users\Melissa\Desktop\Logs\log.txt", true);
            Console.Write("Please type in a number: ");
           
            int number = Convert.ToInt32(Console.ReadLine());
            SW.WriteLine(number);
            SW.Close();
            StreamReader logReader = new StreamReader(@"C:\Users\Melissa\Desktop\Logs\log.txt");
            Console.WriteLine("The number you entered has been written to a log and your displayed number from the log is: ");
            Console.Write(logReader.ReadToEnd());
            
            Console.Read();
        }
    }
}
