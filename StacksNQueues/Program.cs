using System;
using System.Collections.Generic;

namespace StacksNQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> myCharStack = new Stack<char>();

            Queue<char> myCharQueue = new Queue<char>();

            LinkedList<char> myLinkedList = new LinkedList<char>();

            char[] myCharArray = { 'a', 'b', 'c', 'd', 'e' };

            foreach (char character in myCharArray)
            {
                myCharStack.Push(character);
                myCharQueue.Enqueue(character);
                myLinkedList.AddLast(character);
            }


            //This will not work, because the stack gets smaller as it pops
            //for (int i = 0; i < myCharStack.Count; i++)
            //{
            //    Console.WriteLine(myCharStack.Pop());
            //}

            ////Ditto the stack, this will also not work
            //for (int i = 0; i < myCharQueue.Count; i++)
            //    Console.WriteLine(myCharQueue.Dequeue());

            //This will work!
            for (int i = 0; i < myCharArray.Length; i++)
            {
                Console.WriteLine(myCharStack.Pop());
                Console.WriteLine(myCharQueue.Dequeue());
                Console.WriteLine();
            }

            foreach (char node in myLinkedList)
            {
                Console.WriteLine(node);
            }


        }
    }
}
