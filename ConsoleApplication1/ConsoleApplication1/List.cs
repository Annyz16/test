using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class List<N>
    {
        Node<N> head;

        internal Node<N> Head
        {
            get { return head; }
            set { head = value; }
        }


        Node<N> tail;

        internal Node<N> Tail
        {
            get { return tail; }
            set { tail = value; }
        }

       
    }
}
