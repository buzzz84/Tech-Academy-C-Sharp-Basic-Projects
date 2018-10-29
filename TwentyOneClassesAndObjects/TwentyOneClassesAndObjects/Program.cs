using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

    }
}


// Lambda Expressions Examples

//int count = deck.Cards.Count(x => x.Face == Face.Ace); // Lambda function replacing foreach loop to find all the Aces in deck
//Console.WriteLine(count);

//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face);
//}

//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

//int sum = numberList.Sum();

//Console.WriteLine(sum);
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

//int sum = numberList.Sum(x => x + 5);

//Console.WriteLine(sum);
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

//int sum = numberList.Max();

//Console.WriteLine(sum);
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

//int sum = numberList.Min();

//Console.WriteLine(sum);

//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

//int sum = numberList.Where(x => x > 20).Sum();

//Console.WriteLine(sum);
