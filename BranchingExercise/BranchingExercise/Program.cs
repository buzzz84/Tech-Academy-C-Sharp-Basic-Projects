using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int weightLimit = 50;
            
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight > weightLimit)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else if (weightLimit > packWeight)
            {
                int packageDim = 50;
                Console.WriteLine("What is the width of your package?");
                int packWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                int packHeight = Convert.ToInt32(Console.ReadLine());
                int packSize = packHeight + packWidth;

                if (packSize > packageDim)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else if (packSize < packageDim)
                {
                    int product = packWidth * packHeight;
                    decimal price = product / 100.00m;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + price);
                    Console.WriteLine("Thank You");
                    Console.ReadLine();
                }
            }
        }
    }
}
