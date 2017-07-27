using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Sylvere Ekponon
 * Date: July 27, 2017
 * Description: this is the abstract cardList class
 * Version: 0.1 - Created the abstract cardList class
 */

namespace LINQDEMO
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor
        /// </summary>
        public CardList()
        {
            this._initialize();
        }

        //PROTECTED METHODS
        protected abstract void _initialize();

        //PUBLIC METHODS

    }
}