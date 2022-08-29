using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29August
{
    internal class MyStack<T>
    {
        //stack-LIFO 
        public T[] stack;
        public int top, capacity;

        internal bool isStackEmpty()
        {
            return (top < 0);
        }

        public MyStack(int c)
        {
            capacity = c; top = -1;
            stack = new T[capacity];

        }

        internal void Push(T data)
        {
            if (top >= capacity)
            {
                Console.WriteLine("No space on the stack");
                return;
            }
            else
            {
                stack[++top] = data;

            }
        }

        internal void Pop()
        {
            
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                T value = stack[top--];
                Console.WriteLine("deleted element is : " + value);
            }
        }
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                T value = stack[top];
                Console.WriteLine("Top Element is : " + value);
            }
        }

        internal void PrintStackElements()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.Write(stack[i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
