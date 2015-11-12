using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class LinkedList<T>
    {
        private int size;
        //A public property that will point to the Head node. (The first one in the list)
        public GenericNode<T> Head
        {
            get;
            set;
        }

        //Constructor. It will set the Head to null because there is nothing in the list yet.
        public LinkedList(int size)
        {
            Head = null;
            this.size = 0;
        }

        public LinkedList() { }

        public Boolean isEmpty() { return Head == null; }
       

        public void Add(T content)
        {
            //Make a new node to add to the linked list
            GenericNode<T> node = Head;
            //Set the data to the passed in content
            Head = new GenericNode<T>();

            Head.Next = node;
            size++;
        }
           
        public T takeOut()
        {
           
            if (Head == null)
            {
                throw new Exception("Stack is Empty");
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
