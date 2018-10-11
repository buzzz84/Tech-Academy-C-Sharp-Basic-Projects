using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] colorsRainbow = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            Console.WriteLine("Can you guess a color of the rainbow?");
            string userColors = Console.ReadLine();

            foreach (string color in colorsRainbow)
            {
                if (userColors == colorsRainbow[0])
                {
                    Console.WriteLine("You guessed Red. That is a color of the rainbow!");
                    Console.ReadLine();
                    break;
                }
                else if (userColors == colorsRainbow[1])
                {
                    Console.WriteLine("You guessed Orange. That is a color of the rainbow!");
                    Console.ReadLine();
                    break;
                }
                else if (userColors == colorsRainbow[2])
                {
                    Console.WriteLine("You guessed Yellow. That is a color of the rainbow!");
                    Console.ReadLine();
                    break;
                }
                else if (userColors == colorsRainbow[3])
                {
                    Console.WriteLine("You guessed Green. That is a color of the rainbow!");
                    Console.ReadLine();
                    break;
                }
                else if (userColors == colorsRainbow[4])
                {
                    Console.WriteLine("You guessed Green. That is a color of the rainbow!");
                    Console.ReadLine();
                    break;
                }
                else if (userColors == colorsRainbow[5])
                {
                    Console.WriteLine("You guessed Blue. That is a color of the rainbow!");
                    Console.ReadLine();
                    break;
                }
                else if (userColors == colorsRainbow[6])
                {
                    Console.WriteLine("You guessed Indigo. That is a color of the rainbow!");
                    Console.ReadLine();
                    break;
                }
                else if (userColors == colorsRainbow[7])
                {
                    Console.WriteLine("You guessed Violet. That is a color of the rainbow!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("You did not guess a primary color of the rainbow");
                    Console.ReadLine();
                }
            }
    }
}
