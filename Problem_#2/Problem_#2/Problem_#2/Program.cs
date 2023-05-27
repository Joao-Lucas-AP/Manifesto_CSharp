using System;

namespace Problem__2;
class Program
{
    static void Main()
    {
        //myInventory.AddElement adiciona mais itens string a lista.
        LinkedList myInventory = new LinkedList();
        myInventory.AddElement("Cadeira");
        myInventory.AddElement("Lápis");
        myInventory.AddElement("Carro");
        myInventory.AddElement("Água");

        Console.WriteLine("Inventory in order:");
        myInventory.PrintElements(); //Comando para escrever os elementos da lista como estão ordenados.
        Console.WriteLine("\n");

        myInventory.Reverse(); //comando para reverter a ordem da lista.

        Console.WriteLine("Inventory in reverse order:");
        myInventory.PrintElements();
        Console.WriteLine("\n");

        myInventory.AlphabeticOrder(); //Comando para ordenar alfabeticamente.

        Console.WriteLine("Inventory in alphabetic order:");
        myInventory.PrintElements();
        Console.WriteLine("\n");

        myInventory.Reverse();

        Console.WriteLine("Inventory in reverse alphabetic order:");
        myInventory.PrintElements();
    }
}