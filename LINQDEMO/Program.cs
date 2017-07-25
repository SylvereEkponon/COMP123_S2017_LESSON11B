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
 */
namespace LINQDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("Original Desk");
            Console.WriteLine("=======================================================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled Desk");
            Console.WriteLine("=======================================================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
        }
    }
}
