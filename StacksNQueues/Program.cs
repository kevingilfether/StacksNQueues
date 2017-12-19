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
                myCharQueue.Enqueue(character);
                myCharStack.Push(character);
            }

            myCharStack.Push

        }
    }
}
