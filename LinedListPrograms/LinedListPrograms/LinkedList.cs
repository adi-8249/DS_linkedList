using System;
using System.Collections.Generic;
using System.Text;

namespace LinedListPrograms
{
    class LinkedList
    {
        Node head;
        public void Add(int value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    Console.Write(n.value + " ");
                    n = n.next;
                }
                Console.Write(n.value + "\n");
            }
        }
    }
}
