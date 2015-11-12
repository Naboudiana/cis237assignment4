using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack <T> 
    {
        
        LinkedList<T> list = new LinkedList<T>();

        public void Push(T value)
        {
            
            list.Add(value);
        }

        public T Pop()
        {
            while (!list.isEmpty())
            
                 list.takeOut();

            return list.takeOut();       
        }
        
    }
}
