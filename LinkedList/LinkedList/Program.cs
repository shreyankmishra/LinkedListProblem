using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists list = new LinkedLists();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Insert(4, 40);
            list.Display();
            Node p = list.Pop();
            System.Console.WriteLine(p.data);
            list.Display();
        }
    }
}
