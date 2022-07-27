using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasses
{
    class SingleLinkList<T>
    {
        private Node<T> headNode;
        private int count;


        public SingleLinkList()
        {
            this.headNode = null;
            this.count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
        public int Count()
        {
            return count;
        }
        public int Add(T data)
        {
            if (headNode == null)
            {
                headNode = new Node<T>(data);
                count++;
            }
            else
            {
                Node<T> current = headNode;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>(data); 
                count++;
            }

            return count;
        }
        public void printList()
        {
            if (count.Equals(0) || headNode.Equals(null))
            {
                Console.WriteLine("This list is empty");
            }
            Node<T> current = headNode;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        public bool Remove(T data)
        {
            if (headNode.Equals(null) || count.Equals(0))
            {
                throw new System.InvalidOperationException("List is empty");
            }
            else if (headNode.Data.Equals(data))
            {
                headNode = headNode.Next;
                count--;
                return true;
            }
            else
            {
                Node<T> current = headNode;
                while (current.Next != null)
                {
                    if (current.Next.Data.Equals(data))
                    {
                        current.Next = current.Next.Next;
                        count--;
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
        }
        public bool Check(T data)
        {
            if (headNode.Data.Equals(data))
            {
                return true;
            }

            else
            {
                Node<T> current = headNode;
                while (current.Next != null)
                {
                    if (current.Next.Data.Equals(data))
                    {
                        return true;
                    }
                    current = current.Next;
                }

            }
            return false;
        }
        public int Index(T data)
        {
            int index = 0;
            if (headNode.Data.Equals(data))
            {
                return index;
            }
            index++;
            Node<T> current = headNode;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(data))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }
    }
}
