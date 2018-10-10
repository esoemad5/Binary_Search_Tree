using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BianarySearchTree test = new BianarySearchTree(5);
            test.Add(2);
            test.Add(4);
            test.Add(5);
            test.Add(3);
            Console.WriteLine(test.Search(2));
            Console.WriteLine(test.Search(5));
            Console.WriteLine(test.Search(9));
        }
    }
}
