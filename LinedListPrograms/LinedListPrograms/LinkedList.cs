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
        public void Append(int value) 
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (node.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }
        public void InsertInPosition(int position, int value)
        {
            Node node = new Node(value);
            if (position == 0) //when position is 0
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node n = head, Prev = head, after;
                for (int i = 1; i < position; i++)
                {
                    n = n.next;
                    if (i == position - 2)
                    {
                        Prev = n;
                    }
                }
                after = n;
                Prev.next = node;
                node.next = after;
            }
        }
        public Node Pop() //removing the given number from list
        {
            Node n = head;
            if (head == null) //cheking for head is null
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                head = head.next;
            }
            return n;
        }
        public Node PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty.");
                return null;
            }
            else
            {
                Node n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }
                Node removedNode = n.next;
                n.next = null;
                return removedNode;
            }
        }
    }
}
