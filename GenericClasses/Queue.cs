using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasses
{
    class Queue<T>
    {
        private Node<T> head;
        private int count;

        public Queue()
        {
            head = default;
            count = default;
        }
        public void Enqueue(T data)
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
        public T Dequeue()
        {
            if (head == null && count == 0)
            {
                throw new System.InvalidOperationException("This List is empty");
            }
            else if (count == 1)
            {
                var dequeue = head.Data;
                head = null;
                count--;
                return dequeue;
            }
            else
            {
                Node<T> current = head;
                var dequeue = head.Data;
                head = current.Next;
                count--;
                return dequeue;

            }
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
        public int Size()
        {
            return count;
        }
        public void printQueue()
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



    }
}
