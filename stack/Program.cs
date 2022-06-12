using System;
using System.Collections.Generic;
namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>(3);

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("PEEK : "+myStack.Peek());
            Console.WriteLine("POP : "+myStack.Pop());
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
