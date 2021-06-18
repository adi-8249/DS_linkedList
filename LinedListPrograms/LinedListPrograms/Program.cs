using System;

namespace LinedListPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to DataStructure linked list program");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Display();

            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();

            linkedList.InsertInPosition(2,30);
            linkedList.Display();
            Console.WriteLine("Popped first element " + linkedList.Pop().value);

        }
    }
}
