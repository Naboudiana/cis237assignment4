using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T>
    {
        LinkedList_Queue<T> list = new LinkedList_Queue<T>();

        public void Enqueue(T value)
        {
            list.Add(value);
        }

        public T Dequeue()
        {
            return list.Remove();
        }

    }
}
