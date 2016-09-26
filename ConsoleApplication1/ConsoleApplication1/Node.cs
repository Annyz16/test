using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Node<N>
    {
        N Node;
        private N data;

        public N Data
        {
            get { return data; }
            set { data = value; }
        }
        Node<N> next;

        internal Node<N> Next
        {
            get { return next; }
            set { next = value; }
        }
//da sua
    }
}
