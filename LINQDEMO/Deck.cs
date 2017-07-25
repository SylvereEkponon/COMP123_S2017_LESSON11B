﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Sylvere Ekponon
 * Date: July 25, 2017
 * Description:this is the Desk class
 * Version: 0.2 - Added the Shuffle method
 */

namespace LINQDEMO
{
    class Deck : List<Card>
    {

        // PRIVATE INSTANCE VARIABLES
        private Random _random;


        // PUBLIC PROPERTIES



        // CONSTRUCTOR

        /// <summary>

        /// This is the main constructor.

        /// </summary>

        public Deck()

        {

            this._initialize();

        }



        // PRIVATE METHODS



        /// <summary>

        /// This is the Initialize method it sets values for private variables

        /// and public properties as well as other class objects.

        /// </summary>

        private void _initialize()
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
                firstCard = this._random.Next(0, 52);
                secondCard = this._random.Next(0, 52);

                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }
    }
}