using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
     

            Deck deck = new Deck();

            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
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
