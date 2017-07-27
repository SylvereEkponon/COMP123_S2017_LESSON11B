using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Sylvere Ekponon
 * Date: July 25, 2017
 * Description:this is the Demo for Lesson 11
 * Version: 0.1 - created the Project
 * version: 0.2 - Implemented the Desk class
 * version: 0.3 - Test Shuffle method of the Deck class
 * version: 0.4 - Tested the new Desk class
 * version: 0.5 - tested the Deal5 Method
 * version: 0.6 - tested the Highest Card Method
 */
namespace LINQDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());
            hand = deck.Deal5();
            Console.WriteLine(hand);
            hand.HighestCards();
            //hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());
            //Console.WriteLine();
            //hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());
            //Console.WriteLine();
            //Console.WriteLine(deck.ToString());
        }
    }
}
