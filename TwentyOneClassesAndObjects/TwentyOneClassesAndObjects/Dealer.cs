using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //Add first item
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //Logging cards dealt into Log.txt
            Console.WriteLine(card); //Print it to console
            using (StreamWriter file = new StreamWriter(@"C:\Users\Melissa\Desktop\Logs\log.txt", true)) //cleaning up usage to save memory
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); //Remove first item from list
        }
    }
}
