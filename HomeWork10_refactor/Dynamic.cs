using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_refactor
{
    abstract class Dynamic<T>
    {
        protected T[] array;
        protected int top;
        protected int count;
        protected int head;
        protected int tail;
        protected int capacity;
        protected int size;

        public Dynamic(T[] Array, int capacity)
        {
            this.array = Array;
            this.top = 0;
            this.count = 0;
            this.head = 0;
            this.tail = 0;
            this.capacity = capacity;
            this.size = capacity;

        }
    }
}
