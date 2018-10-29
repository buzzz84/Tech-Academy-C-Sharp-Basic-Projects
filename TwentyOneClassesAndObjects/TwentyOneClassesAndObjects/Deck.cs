using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            
            Cards = new List<Card>(); //This is linking to the property of the class - starts as empty list of cards

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //values given to Cards
            //List<string> Faces = new List<string>() // values given to list
            //{
            //    "Two", "Three", "Four", "Five", "Six", "Seven",
            //    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            //};

            ////Nested Foreach Loop
            //foreach (string face in Faces) //loops 4 times- once for each suit
            //{
            //    foreach (string suit in Suits) //loops 13 times- once for each face
            //    {
            //        Card card = new Card(); //creates new card- this Card value only exists in each loop instance.
            //        card.Suit = suit; // gives suit value
            //        card.Face = face; // gives face value
            //        Cards.Add(card); // adds card into cards list
            //    }
            //}
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>(); //Temp list to house cards for shuffling action
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); // needs two numbers. first is zero, second is count of deck left
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

        }
    }
}
