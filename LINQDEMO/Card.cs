using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Sylvere Ekponon
 * Date: July 25, 2017
 * Description:this is the card class
 * Version 0.2 - Added the Overwrite method
 */

namespace LINQDEMO
{
    //This is the Card class
    public class Card : ICloneable
    {
        // PRIVATE INSTANCE VARIABLES

        private Face _face;

        private Suit _suit;



        // PUBLIC PROPERTIES

        public Face Face
        {
            get

            {

                return this._face;

            }
            set

            {

                this._face = value;

            }

        }



        public Suit Suit
        {

            get

            {

                return this._suit;

            }

            set

            {

                this._suit = value;

            }

        }



        // CONSTRUCTORS



        /// <summary>

        /// This is the main constructor.

        /// It takes two parameters - face (Face) - suit (Suit)

        /// </summary>

        /// <param name="face"></param>

        /// <param name="suit"></param>

        public Card(Face face, Suit suit)

        {

            this.Face = face;

            this.Suit = suit;

        }




        // PRIVATE METHODS



        // PUBLIC METHODS
        /// <summary>
        /// This method overrides the built-in Clone method.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }

        /// <summary>
        /// This method takes the properties of the first card and overwrites the properties of the second card
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void Overwrite(Card first, Card second)
        {
            first.Face = second.Face;
            first.Suit = second.Suit;
        }

    }
}
