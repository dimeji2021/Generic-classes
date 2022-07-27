using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GenericClasses
{
    class Stack<T>
    {
        private Node<T> head = default;
        private int count = 0;

        public Stack()
        {

        }

        public bool IsEmpty()
        {
            return count == 0;
        }
        public int Size()
        {
            return count;
        }

        public void Push(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                count++;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>(data);
                count++;
            }
        }
        public T Peek()
        {
            if (head == null && count == 0)
            {
                throw new System.InvalidOperationException("This list is empty");
            }
            else if (count.Equals(1))
            {
                return head.Data;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                return current.Data;
            }
        }
        public T Pop()
        {
            if (head == null && count == 0)
            {
                throw new System.InvalidOperationException("This list is empty");
            }
            else if (count.Equals(1))
            {
                var poped = head.Data;
                head = null;
                count--;
                return poped;
            }
            else
            {
                Node<T> current = head;
                Node<T> previous = null;

                while (current.Next != null)
                {
                    previous = current;
                    current = current.Next;
                }
                var poped = current.Data;
                previous.Next = null;
                count--;
                return poped;
            }
        }
        public void PrintStack()
        {
            if (head == null || count == 0)
            {
                Console.WriteLine("This stack is empty");
            }
            else
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }

        public int IndexOf(T data)
        {
            int index = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (data.Equals(current.Data))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public T this[int index]
        {
            get
            {
                Node<T> current = head;
                while (current != null)
                {
                    if (IndexOf(current.Data).Equals(index))
                    {
                        return current.Data;
                    }
                    current = current.Next;
                }
                throw new IndexOutOfRangeException("Index " + index);
            }

            set
            {

                this[index] = value;
            }

        }

    }
}
