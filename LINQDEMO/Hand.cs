using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Sylvere Ekponon
 * Date: July 27, 2017
 * Description: this is the Hand class
 * It inherits from the the cardList abstract class
 * Version: 0.1 - Created the Hand Class
 */

namespace LINQDEMO
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS

        protected override void _initialize()

        {
            // STUB
            // this method is empty
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
            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }
    }
}