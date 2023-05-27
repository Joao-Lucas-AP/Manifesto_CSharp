using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem__2
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void AddElement(string value)
        {
            Node newNode = new Node(value);

            if (IsEmpty())
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void PrintElements()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Node current = Head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }

        public void Reverse()
        {
            Node previous = null;
            Node current = Head;
            Node nextNode = null;

            while (current != null)
            {
                nextNode = current.Next;
                current.Next = previous;
                previous = current;
                current = nextNode;
            }

            Head = previous;
        }

        public void AlphabeticOrder()
        {
            if (IsEmpty() || Head.Next == null)
            {
                return;
            }

            bool swapped;
            do
            {
                swapped = false;
                Node previous = null;
                Node current = Head;
                while (current.Next != null)
                {
                    Node nextNode = current.Next;
                    if (string.Compare(current.Value, nextNode.Value) > 0)
                    {
                        if (previous == null)
                        {
                            Head = nextNode;
                        }
                        else
                        {
                            previous.Next = nextNode;
                        }
                        current.Next = nextNode.Next;
                        nextNode.Next = current;
                        swapped = true;
                    }
                    previous = current;
                    current = nextNode;
                }
            }
            while (swapped);
        }
    }
}
