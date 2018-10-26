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
            /*Game game = new TwentyOneGame();*/ //PolyMorphism- ability of a class to morph into its inheriting class and give certain advantages
                                                 //TwentyOneGame game = new TwentyOneGame();
                                                 //game.Players = new List<string>() { "Jesse", "Bill", "Bob" }; -- 
                                                 //game.ListPlayers();
                                                 //Console.ReadLine();
                                                 //Game game = new TwentyOneGame();
                                                 //game.Players = new List<Player>();
                                                 //Player player = new Player();
                                                 //player.Name = "Jesse";
                                                 //game += player; // same as game = game + player; 
                                                 //game -= player; // same as game = game - player;
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);
            Console.Read();

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        

        

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
