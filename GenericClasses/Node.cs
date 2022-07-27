using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasses
{
    class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }


        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}

