using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder userString = new StringBuilder();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Tell me your top five favorite Seahawks of all time");
            //    userString.Append(Console.ReadLine());
            //}
            //Console.WriteLine(userString);
            //Console.ReadLine();


            //Infinite Loop
            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine("Infinite Loop", i);
            //}

            //Infinite Loop Closed
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine("Closed Infinite Loop", i);
            //    Console.ReadLine();
            //}

            //Loop using Comparison "<"
            //int[] primeNumbers = { 2, 3, 5, 7, 13, 17, 19, 23, 29 };

            //for (int i = 0; i < primeNumbers.Length; i++)
            //{
            //        Console.WriteLine(primeNumbers[i]);
            //}
            //Console.ReadLine();


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


            //String[] colorsRainbow = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            //Console.WriteLine("Can you guess a color of the rainbow?");
            //string userColors = Console.ReadLine();

            //foreach (string colors in colorsRainbow)
            //{
            //    if (userColors == colorsRainbow[0])
            //    {
            //        Console.WriteLine("You guessed Red. That is a color of the rainbow!");
            //        Console.ReadLine();
            //        break;
            //    }
            //    else if (userColors == colorsRainbow[1])
            //    {
            //        Console.WriteLine("You guessed Orange. That is a color of the rainbow!");
            //        Console.ReadLine();
            //        break;
            //    }
            //    else if (userColors == colorsRainbow[2])
            //    {
            //        Console.WriteLine("You guessed Yellow. That is a color of the rainbow!");
            //        Console.ReadLine();
            //        break;
            //    }
            //    else if (userColors == colorsRainbow[3])
            //    {
            //        Console.WriteLine("You guessed Green. That is a color of the rainbow!");
            //        Console.ReadLine();
            //        break;
            //    }
            //    else if (userColors == colorsRainbow[4])
            //    {
            //        Console.WriteLine("You guessed Blue. That is a color of the rainbow!");
            //        Console.ReadLine();
            //        break;
            //    }
            //    else if (userColors == colorsRainbow[5])
            //    {
            //        Console.WriteLine("You guessed Indigo. That is a color of the rainbow!");
            //        Console.ReadLine();
            //        break;
            //    }
            //    else if (userColors == colorsRainbow[6])
            //    {
            //        Console.WriteLine("You guessed Violet. That is a color of the rainbow!");
            //        Console.ReadLine();
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You did not guess a primary color of the rainbow");
            //        Console.ReadLine();
            //        break;
            //    }

            //string[] fantasyLeaguemates = { "Tod", "Gary", "Alisha", "Ryan", "Josh", "Scott", "Scott", "Ryan", "Greg", "Travis", "Jason", "Tony" };
            //Console.WriteLine("Can you guess a name of a league owner in my fantasy football league?");
            //string leaguemateGuess = Console.ReadLine();
            //string leagueMates = Convert.ToString(Console.ReadLine());
            //bool guessed = false;

            //do
            //{
            //    switch (leagueMates)
            //    {
            //        for (int j = 0; j < fantasyLeaguemates.Length; j++)
            //    {
            //        guessed = false;
            //        if (fantasyLeaguemates[j] == leaguemateGuess)
            //        {
            //            Console.WriteLine(fantasyLeaguemates[j]);
            //            Console.ReadLine();
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("You did not guess a league mate in my league.");
            //            Console.ReadLine();
            //            break;
            //        }
            //    }



            //}



            List<string> fantasyLeaguemates = new List<string>() { "Tod", "Gary", "Alisha", "Ryan", "Josh", "Scott", "Scott", "Ryan", "Greg", "Travis", "Jason", "Tony" };

            foreach (string owner in fantasyLeaguemates)
            {
                
                foreach (string owner2 in fantasyLeaguemates)
                {
                    if (owner == owner2)
                Console.WriteLine("");
                Console.ReadLine();
            }

        }
     }
 }


//        for (int i = 1; i<fantasyLeaguemates.Count - 1; i++)

//            {

//                for (int j = i + 1; j<fantasyLeaguemates.Count - 1; i++)

//                {

//                    if (fantasyLeaguemates(i) == fantasyLeaguemates(j))


//                    {

//                        Console.WriteLine("The Duplicate found is" + fantasyLeaguemates(i));
//                    }
//}