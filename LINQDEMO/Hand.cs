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
 * Version: 0.2 - Added the Highest Card Method
 * Version: 0.3 - Refactored the Highest Card Method
 * Version: 0.4 - Refactored the Highest Card Method
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

        /// <summary>
        /// This is the HighestCards method
        /// </summary>
        public void HighestCards()
        {
            var sorted = from card in this
                         orderby card.Face
                         select card;
            var reserveOrder = from card in sorted
                               orderby card.Face descending
                               select card;
            Console.Write("The HIGHEST card is \n");
            foreach (var item in reserveOrder)
            {
                if ((int)item.Face==(int)reserveOrder.First().Face)
                {
                    Console.WriteLine(item);
                }
            }
            //Console.WriteLine("\nThe Highest Card is "+reserveOrder.First());

            
        }
    }
}