using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29August
{
    internal class Queue
    {
        private int front, rear, capacity;
        private int[] queue;

        public Queue(int c)
        {
            front = rear = 0;
            capacity = c;
            queue = new int[capacity];
        }

       
        public void Enqueue(int data)
        {
          
            if (capacity == rear)
            {
                Console.WriteLine("Queue is full");
                return;
            }

            else
            {
                queue[rear] = data;
                rear++;
            }
            return;
        }


        public void Dequeue()
        {
            

            if (front == rear)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            else
            {
                Console.WriteLine("Deleted element is : " + queue[front]);
                for (int i = 0; i < rear - 1; i++)
                { 
                    queue[i] = queue[i + 1];
                   
                }
                if (rear < capacity)
                    queue[rear] = 0;
                
                rear--;
                
            }
            
            return;
        }


        public void DisplayData()
        {
            int i;
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            for (i = front; i < rear; i++)
            {
                Console.Write( queue[i]+"\t");
               
            }
            Console.WriteLine();
            return;
        }


        public void Peek()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("Front Element is: {0}", queue[front]);
            return;
        }
    }
}
