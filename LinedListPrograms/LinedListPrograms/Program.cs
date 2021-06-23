using System;

namespace LinedListPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome message for linked list program
            Console.WriteLine("WelCome to DataStructure linked list program");
            // object creation
            LinkedList linkedList = new LinkedList();
            //Adding elements using Add method
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Display();
            //appendinging the elements using Append method
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
            //inserting elements in given position
            linkedList.InsertInPosition(2,30);
            linkedList.Display();
            //Using pop method removing element from first position
            linkedList.Pop();
            linkedList.Display();
            //inserting the elements
            linkedList.Append(70);
            linkedList.Append(30);
            linkedList.Append(56);
            linkedList.Display();
            //using poplast method removing element from last 
            linkedList.PopLast();
            linkedList.Display();
            //using search method finding the element from list
            linkedList.Search(30);
            linkedList.Display();
            //Inserting the value 40 in the second position
            linkedList.InsertInPosition(2, 40);
            linkedList.Display();
            //deleteing the element from list and shows size
            linkedList.DeleteElement(40);
            linkedList.Display();
            Console.WriteLine( "The Size of Linked List is: " + linkedList.ShowSize());
        }
    }
}
