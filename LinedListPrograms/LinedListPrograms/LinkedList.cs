using System;
using System.Collections.Generic;
using System.Text;

namespace LinedListPrograms
{
    public class LinkedList
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
        public Node PopLast()//Removing element from last of list
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
        /// <summary>
        /// searching for the specific value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.value == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
        /// <summary>
        /// Deleting element 40 from list
        /// </summary>
        /// <param name="value"></param>
        public void DeleteElement(int value)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.value == value)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.value != value)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;

            prev.next = temp.next;
            Console.WriteLine("{0} Element is Deleted", value);
        }
        /// <summary>
        /// showing the size 
        /// </summary>
        /// <returns></returns>
        public int ShowSize()
        {
            Node temp = head;
            int size = 0;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
    }
}
