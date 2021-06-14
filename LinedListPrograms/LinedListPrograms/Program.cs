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
        }
    }
}
