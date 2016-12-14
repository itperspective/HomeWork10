using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class DynamicArray<T> : DynamicArrayAbstract<T>
    {
        public DynamicArray(T[] Array, int size) : base(Array, size)
        {
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

        public override void Print()
        {
            Console.WriteLine("Your stack looks like this now:");
            Console.Write("[");
            for (int i = 0; i < top + 1; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write("]");
        }

        protected void ArrayGrowthAdd()
        {
            capacity = capacity * 2;
            T[] array1 = new T[capacity];
            for (int i=0; i<array.Length; i++)
            {
                array1[i] = array[i];
            }

            array = array1;
                      
        }
        protected void ArrayGrowthInsert(int index)
        {
            capacity = capacity * 2;
            T[] array1 = new T[capacity];
            for (int i = 0; i < index; i++)
            {
                array1[i] = array[i];
            }

            //array1[index] = array[index];
            for (int i = index; i<array.Length; i++)
            {
                array1[i+1] = array[i];
            }

            array = array1;

        }


        public T Get(int index)
        {

            Console.WriteLine("Get from DynamicArray:");
            return array[index];


        }

        public void Add(T add)
        {
            if (IsFull() )
            {
                ArrayGrowthAdd();
                array[top] = add;
                top = top + 1;
            }
            else
            {
                array[top] = add;
                top = top + 1;
            }
        }

        public void Insert(T add, int index)
        {
            if (index >= top)
            {
                Console.WriteLine("Index is out of range");
            }
            else if (IsFull())
            {
                ArrayGrowthInsert(index);
                array[index] = add;
                top = top + 1;
            }
            

            else 
            {
                
                for (int i = top; i > index; i--)
                {
                    array[i]=array[i-1];
                }

                array[index] = add;
                top = top + 1;

            }
            
        }

        public void Remove(int index)
        {
            
            if (!IsEmpty() & index<=top-1)
            {
                Console.WriteLine("Remove value [{0}] from stack", array[index]);
                T[] array1 = new T[capacity];
                for (int i = 0; i < index; i++)
                {
                    array1[i] = array[i];
                }

                for (int i = index; i < array.Length - 1; i++)
                {
                    array1[i] = array[i + 1];
                }

                array = array1;
                top = top - 1;
            }

            else if ((!IsEmpty()) & (index>top-1))
                { Console.WriteLine("Index is out of range!"); }
            else 
            { Console.WriteLine("Stack is Empty!"); }

        }

        //just for testing
        public void PrintAllArray()
        {
            Console.Write("[ ");
            for (int i=0; i<array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");

            }
            Console.Write(" ]");

            Console.WriteLine("SIZE :{0}, CAPACITY:{1}", top, array.Length);
        }


    }
}
