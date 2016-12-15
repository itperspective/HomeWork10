using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_refactor
{
    class Stack<T> : DynamicArray<T>
    {


        public T Peek()
        {

            return Get(top-1);
        }

        public T Pop()
        {
            T a = Get(top-1);
            Remove(top-1);
            return a;
         }

        public void Push(T push)
        {
            Add(push);
        }

    

        

    }
}
