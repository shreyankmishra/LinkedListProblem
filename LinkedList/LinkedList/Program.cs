using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedLists sorted = new SortedLinkedLists();
            sorted.Add(56, sorted);
            sorted.Add(30, sorted);
            sorted.Add(40, sorted);
            sorted.Add(70, sorted);
            sorted.Display();
        }
    }
}
