using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Sylvere Ekponon
 * Date: July 25, 2017
 * Description:this is the Desk class
 * Version:created the Desk class
 */

namespace LINQDEMO
{
    class Deck : List<Card>
    {

        // PRIVATE INSTANCE VARIABLES



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
    }
}
