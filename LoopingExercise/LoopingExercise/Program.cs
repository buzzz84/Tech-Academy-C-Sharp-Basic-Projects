using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementsPractice
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Guess my favorite color!");
            string favColor = Convert.ToString(Console.ReadLine());
            bool colorGuess = favColor == "red";
            switch (favColor)

            {
                case "blue":
                    Console.WriteLine("You guessed Blue. Try again");
                    break;
                case "green":
                    Console.WriteLine("You guessed Green. Try again");
                    break;
                case "orange":
                    Console.WriteLine("You guessed Orange. Try again");
                    break;
                case "red":
                    Console.WriteLine("You guessed the color Red. That is correct!!!");
                    colorGuess = true;
                    break;
                default:
                    Console.WriteLine("You guessed the wrong color.");
                    break;
            }

            Console.Read();

            //Console.WriteLine("In what round was Russell Wilson drafted by the seahawks?");
            //int roundDrafted = Convert.ToInt32(Console.ReadLine());
            //bool roundGuess = roundDrafted == 3;


            //do
            //{
            //    switch (roundDrafted)
            //    {
            //        case 1:
            //            Console.WriteLine("You guessed round 1. Try again");
            //            Console.WriteLine("Guess another round.");
            //            roundDrafted = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 2:
            //            Console.WriteLine("You guessed round 2. Try again");
            //            Console.WriteLine("Guess another round.");
            //            roundDrafted = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 3:
            //            Console.WriteLine("You guessed round 3. The Seahawks stole Wilson!!!");
            //            roundGuess = true;
            //            break;
            //        case 4:
            //            Console.WriteLine("You guessed round 4. Try again");
            //            Console.WriteLine("Guess another round.");
            //            roundDrafted = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        default:
            //            Console.WriteLine("You guessed the wrong round.");
            //            Console.WriteLine("Guess another round");
            //            roundDrafted = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!roundGuess);

            //Console.Read();

        }
    }
}