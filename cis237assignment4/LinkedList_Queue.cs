using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class LinkedList_Queue<T>
    {
        private int size;
        //A public property that will point to the Head node. (The first one in the list)
        public GenericNode<T> Head
        {
            get;
            set;
        }

        public GenericNode<T> Tail
        {
            get;
            set;
        }
              
        public LinkedList_Queue() { }
        //Constructor. It will set the Head to null because there is nothing in the list yet.
        public LinkedList_Queue(int size)
        {
            Head = null;
            this.size = 0;
        }

        public void Add(T content)
        {
            //Make a new node to add to the linked list
            GenericNode<T> node = new GenericNode<T>();
            //Set the data to the passed in content
            node.Data = content;

            if (Head == null)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                Tail.Next = node;
                Tail = Tail.Next;
            }                      
            size++;
        }

        public T Remove()
        {
            if (Head == null)
            {
                throw new Exception("Queue is Empty");
            }
            GenericNode<T> current = Head.Next;

            if (size > 0)
            {
                Head = Head.Next;
                size--;
            }
            return current.Data;
        }
    }
}
