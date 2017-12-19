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

            char[] myCharArray = { 'a', 'b', 'c', 'd', 'e' };

            foreach (char character in myCharArray)
            {
                myCharStack.Push(character);
                myCharQueue.Enqueue(character);
            }

            for (int i = 0; i < myCharStack.Count; i++)
                Console.WriteLine(myCharStack.Pop());

            for (int i = 0; i < myCharQueue.Count; i++)
                Console.WriteLine(myCharQueue.Dequeue());
            
            
        }
    }
}
