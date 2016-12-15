using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_refactor
{
    class Stack<T> 
    {

        DynamicArray<T> dynamicArray = new DynamicArray<T>();

      

        public T Peek()
        {

            return dynamicArray.Get(dynamicArray.top - 1);
        }

        public T Pop()
        {
            T a = dynamicArray.Get(dynamicArray.top-1);
            dynamicArray.Remove(dynamicArray.top - 1);
            return a;
         }

        public void Push(T push)
        {
            dynamicArray.Add(push);
        }

        public void Print()
        {
            dynamicArray.Print();
        }



    }
}
