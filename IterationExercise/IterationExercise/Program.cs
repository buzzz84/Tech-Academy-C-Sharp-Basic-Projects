using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExercise
{
    class Program
    {
        private static void Main(string[] args)
        {
            // 1.
            //StringBuilder userString = new StringBuilder();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Tell me your top five favorite Seahawks of all time");
            //    userString.Append(Console.ReadLine());
            //}
            //Console.WriteLine(userString);
            //Console.ReadLine();

            // 2.
            //Infinite Loop
            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine("Infinite Loop", i);
            //}

            // 3.
            //Infinite Loop Closed
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine("Closed Infinite Loop", i);
            //    Console.ReadLine();
            //}

            // 4.
            //Loop using Comparison "<"
            //int[] primeNumbers = { 2, 3, 5, 7, 13, 17, 19, 23, 29 };

            //for (int i = 0; i < primeNumbers.Length; i++)
            //{
            //        Console.WriteLine(primeNumbers[i]);
            //}
            //Console.ReadLine();

            // 5.
            //Loop using Comparison"<="
            //int[] userInt = new int[10];

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Enter a number:");
            //    userInt[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int i in userInt)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            // 6, 7, 8
            //String[] colorsRainbow = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            //Console.WriteLine("Can you guess a color of the rainbow?");
            //string userColors = Console.ReadLine();
            //bool isFound = false;

            //while (!isFound)
            //{
            //    foreach (string colors in colorsRainbow)
            //    {
            //        if (userColors == colorsRainbow[0])
            //        {
            //            Console.WriteLine("You guessed Red. That is a color of the rainbow!");
            //            isFound = true;
            //            break;
            //        }
            //        else if (userColors == colorsRainbow[1])
            //        {
            //            Console.WriteLine("You guessed Orange. That is a color of the rainbow!");
            //            isFound = true;
            //            break;
            //        }
            //        else if (userColors == colorsRainbow[2])
            //        {
            //            Console.WriteLine("You guessed Yellow. That is a color of the rainbow!");
            //            isFound = true;
            //            break;
            //        }
            //        else if (userColors == colorsRainbow[3])
            //        {
            //            Console.WriteLine("You guessed Green. That is a color of the rainbow!");
            //            isFound = true;
            //            break;
            //        }
            //        else if (userColors == colorsRainbow[4])
            //        {
            //            Console.WriteLine("You guessed Blue. That is a color of the rainbow!");
            //            isFound = true;
            //            break;
            //        }
            //        else if (userColors == colorsRainbow[5])
            //        {
            //            Console.WriteLine("You guessed Indigo. That is a color of the rainbow!");
            //            isFound = true;
            //            break;
            //        }
            //        else if (userColors == colorsRainbow[6])
            //        {
            //            Console.WriteLine("You guessed Violet. That is a color of the rainbow!");
            //            isFound = true;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("You did not guess a primary color of the rainbow");
            //            Console.WriteLine("Can you guess a color of the rainbow this time?");
            //            userColors = Console.ReadLine();
            //            break;
            //        }
            //    }
            //    Console.Read();

            //}

            // 9.
            //List<string> fantasyPlayers = new List<string> { "Tod", "Gary", "Alisha", "Ryan", "Josh", "Scott", "Scott", "Ryan", "Greg", "Travis", "Jason", "Tony" };
            //Console.WriteLine("Can you guess a name of a league owner in my fantasy football league?");
            //string leaguemateGuess = Convert.ToString(Console.ReadLine());

            //foreach (string owner in fantasyPlayers)
            //{
            //    if (leaguemateGuess == "Tod")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else if (leaguemateGuess == "Gary")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else if (leaguemateGuess == "Alisha")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else if (leaguemateGuess == "Ryan")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else if (leaguemateGuess == "Josh")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else if (leaguemateGuess == "Scott")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else if (leaguemateGuess == "Greg")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else if (leaguemateGuess == "Travis")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else if (leaguemateGuess == "Jason")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else if (leaguemateGuess == "Tony")
            //    {
            //        Console.WriteLine("You guessed my leaguemate " + leaguemateGuess);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You did not guess one of my league mates name.");
            //        break;

            //    }

            //}
            //Console.ReadLine();

            // 10.
            List<string> foods = new List<string>() { "nuts", "nuts", "milk", "milk", "apples", "apples" };
            List<string> matchingFoods = new List<string>();

            foreach (string food in foods)
            {
                if (food == "nuts")
                {
                    matchingFoods.Add(food);
                }
            }

            Console.WriteLine(matchingFoods.Count);
            Console.ReadLine();
        }
    }
}



