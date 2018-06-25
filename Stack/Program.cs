using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack(4);
            theStack.Push("Star Wars");
            theStack.Push("Jaws");
            theStack.Push("Jaws 2");
            theStack.Push("Titanic");
            theStack.Push("Rocky");

            WriteLine("================== \nAbout to peak:");
            WriteLine("'" + theStack.Peek() + "'" + " is at the top of the stack.\n");
            WriteLine("================== \nThe stack contains:\n");
            while (!theStack.IsEmpty())
            {
                string movie = theStack.Pop();
                WriteLine(movie);
            }

            ReadLine();
        }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void Push(string m)
        {
            if (IsFull())
            {
                WriteLine("The stack is full.");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                WriteLine("This stack is empty.");
                return "--";
            }
            else
            {
                int oldTop = top;
                top--;
                return stackArray[oldTop];
            }
        }

        public string Peek()
        {
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        private bool IsFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
