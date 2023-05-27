using System;
using System.Security.Cryptography;

namespace Problema__3
{
    class Program
    {
        static void Main()
        {
            Deck deck = new Deck();
            Console.WriteLine("Initial deck:");
            deck.PrintDeck();

            Console.WriteLine("\n___________________\n");

            deck.Shuffle();
            Console.WriteLine("\nShuffled deck:");
            deck.PrintDeck();
        }
    }
}