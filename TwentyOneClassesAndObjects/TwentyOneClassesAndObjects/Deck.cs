using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneClassesAndObjects
{
    public class Deck
    {
        public Deck()
        {
            
            Cards = new List<Card>(); //This is linking to the property of the class - starts as empty list of cards
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //values given to Cards
            List<string> Faces = new List<string>() // values given to list
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //Nested Foreach Loop
            foreach (string face in Faces) //loops 4 times- once for each suit
            {
                foreach (string suit in Suits) //loops 13 times- once for each face
                {
                    Card card = new Card(); //creates new card- this Card value only exists in each loop instance.
                    card.Suit = suit; // gives suit value
                    card.Face = face; // gives face value
                    Cards.Add(card); // adds card into cards list
                }
            }
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; }
    }
}
