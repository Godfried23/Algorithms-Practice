using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue(5);
            myQueue.Insert(100);
            myQueue.Insert(10);
            myQueue.Insert(20);
            myQueue.Insert(30);
            myQueue.View();

            WriteLine($"Front of queue is {myQueue.PeekFront()} ");

            WriteLine("About to remove an item from queue.");
            myQueue.Remove();
            WriteLine($"Front of queue is {myQueue.PeekFront()} ");

            ReadLine();
        }

        public class Queue
        {
            private int maxSize;
            private long[] myQueue;
            private int front;
            private int rear;
            private int items;

            public Queue(int size)
            {
                maxSize = size;
                myQueue = new long[size];
                front = 0;
                rear = -1;
                items = 0;
            }

            public void Insert(long j)
            {
                if (IsFull())
                {
                    WriteLine("Queue is full");
                }
                else
                {
                    if (rear == maxSize - 1)
                    {
                        rear = -1;
                    }

                    rear++;
                    myQueue[rear] = j;
                    items++;
                }
            }

            public long Remove()
            {
                long temp = myQueue[front];
                front++;

                if (front == maxSize)
                {
                    front = 0;
                }

                return temp;
            }

            public long PeekFront()
            {
                return myQueue[front];
            }

            public bool IsEmpty()
            {
                return (items == 0);    
            }

            private bool IsFull()
            {
                return (items == maxSize);
            }

            public void View()
            {
                Write("[");
                for (int i = 0; i < myQueue.Length; i++)
                {
                    Write(myQueue[i] + " ");
                }
                WriteLine("]");

            }
        }
    }
}
