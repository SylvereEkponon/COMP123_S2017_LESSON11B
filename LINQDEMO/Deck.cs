using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Sylvere Ekponon
 * Date: July 25, 2017
 * Description:this is the Desk class
 * It inherits from the the cardList abstract class
 * Version: 0.6 - Added the Deal5 method
 */

namespace LINQDEMO
{
    class Deck : CardList
    {

        // PRIVATE INSTANCE VARIABLES
        private Random _random;


        // PUBLIC PROPERTIES




        // PRIVATE METHODS



        /// <summary>

        /// This is the Initialize method it sets values for private variables

        /// and public properties as well as other class objects.

        /// </summary>

        protected override void _initialize()
        {
            //initialize the pseudo-random number generator
            this._random = new Random();

            //
            for (int suit = (int)Suit.Diamonds; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }


        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>

        public override string ToString()
        {
            string outputString = "";
            outputString += "Deck Contains Number of Cards: " + this.Count + "\n";
            outputString += "=======================================================\n";
            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// this method shuffles the deck by using random indices
        /// to select to Card at the time. It uses a Fisher-Yates like algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this._random.Next(0, this.Count);
                secondCard = this._random.Next(0, this.Count);

                tempCard = (Card)this[secondCard].Clone();
                Card.Overwrite(this[secondCard], this[firstCard]);
                Card.Overwrite(this[firstCard], tempCard);

                //this[secondCard].Face = this[firstCard].Face;
                //this[secondCard].Suit = this[firstCard].Suit;
                //this[firstCard].Face = tempCard.Face;
                //this[firstCard].Suit = tempCard.Suit;
            }
        }

        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0); //this removes the top card from the deck

            //
            Console.WriteLine("Dealt 1 card - Size of Deck: " + this.Count);
            return topCard;
        }

        public Hand Deal5()
        {
            Hand hand = new Hand();
            for (int i = 0; i < 5; i++)
            {
                Card topCard = this[0];
                this.RemoveAt(0);
                hand.Add(topCard);
            }
            return hand;
        }
    }
}
