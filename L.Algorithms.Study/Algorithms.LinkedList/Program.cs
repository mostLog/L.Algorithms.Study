using System;

namespace Algorithms.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            SingleList<int> singleList = new SingleList<int>();

            singleList.Append(1);
            singleList.Append(2);
            singleList.Append(3);
            singleList.Append(4);
            Console.WriteLine(singleList.GetLength());
            Console.ReadLine();
        }
    }
}
