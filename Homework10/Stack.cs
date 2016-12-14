using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Stack<T> : DynamicArrayAbstract<T>
    {
        public Stack(T[] Array, int capacity) : base(Array, capacity)
        {
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        protected void ArrayGrowthAdd()
        {
            capacity = capacity * 2;
            T[] array1 = new T[capacity];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i];
            }

            array = array1;

        }


        protected bool IsEmpty()
        {
            if (top == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool IsFull()
        {
            if (top == array.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Peek()
        {
            if (!IsEmpty())
            {
                
                Console.WriteLine(" Peeked from stack:" + array[top-1]);
                
            }
            else Console.WriteLine("Stack is empty!!!!!");
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                
                top = top - 1;
                Console.WriteLine("Popped:" + array[top]);
            }
            else Console.WriteLine("Stack is empty!!!!!") ;
        }

        public void Push(T push)
        {
            if (IsFull())
            {
                ArrayGrowthAdd();
                array[top] = push;
                top = top + 1;
            }
            else
            {
                array[top] = push;
                top = top + 1;
            }
        }

        //public void PrintAllArray()
        //{
        //    Console.Write("[ ");
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(" " + array[i] + " ");

        //    }
        //    Console.Write(" ]");

        //    Console.WriteLine("SIZE :{0}, CAPACITY:{1}", top, array.Length);
        //}

        public void PrintStack()
        {
            Console.WriteLine("Your stack looks like this now:");
            Console.Write("[");
            for (int i = 0; i < top; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine("SIZE :{0}, CAPACITY:{1}", top, array.Length);
        }

    }
}
