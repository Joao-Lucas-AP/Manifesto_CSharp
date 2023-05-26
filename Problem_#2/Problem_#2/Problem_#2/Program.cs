using System;

namespace Problem__2;
class Program
{
    static void Main()
    {
        LinkedList myInventory = new LinkedList();
        myInventory.AddElement(1);
        myInventory.AddElement(2);
        myInventory.AddElement(3);
        myInventory.AddElement(4);

        Console.WriteLine("Inventory in order:");
        myInventory.PrintElements();

        myInventory.Reverse();

        Console.WriteLine("Inventory in reverse order:");
        myInventory.PrintElements();
    }
}