using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneClassesAndObjects
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //Add first item
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //Print it to console
            Deck.Cards.RemoveAt(0); //Remove first item from list
        }
    }
}
