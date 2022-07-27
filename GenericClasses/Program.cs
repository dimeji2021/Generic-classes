using System;
namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList<string> list = new SingleLinkList<string>();

            //Console.WriteLine("The list is empty " + list.IsEmpty());
            //Console.WriteLine("Count " + list.Count());

            //list.Add("Test 1");
            //list.Add("Test 2");
            //list.Add("Test 3");
            //list.Add("Test 4");
            //list.printList();
            //Console.WriteLine($"{1} is contained in the list and has been removed {list.Remove("Test 1")}");
            //list.printList();
            //Console.WriteLine($"{5} is contained in the list and has been removed {list.Remove("Test 5")}");

            //Console.WriteLine("Check " + list.Check("Test 1"));
            //Console.WriteLine("Check " + list.Check("Test 3"));
            //Console.WriteLine("Check " + list.Check("Test 5"));

            //Console.WriteLine("IndexOf " + list.Index("Test 1"));
            //Console.WriteLine("IndexOf " + list.Index("Test 3"));
            //Console.WriteLine("IndexOf " + list.Index("Test 4"));

            Queue<string> ls = new Queue<string>();
            //Console.WriteLine("This ls is empty {0}", ls.IsEmpty());
            //ls.Enqueue("val");
            //ls.Enqueue("ent");
            //ls.Enqueue("ine.");
            //ls.printQueue();

            //Console.WriteLine("This ls is empty {0}", ls.IsEmpty());
            //Console.WriteLine("The item at the head of the ls is {0}", ls.Dequeue());


            //ls.printQueue();
            //Console.WriteLine("This ls is empty {0}", ls.IsEmpty());

            Stack<double> stack = new Stack<double>();

            Console.WriteLine("This stack is empty {0}", stack.IsEmpty());
            Console.WriteLine("This stack is  {0} in size", stack.Size());
            stack.Push(0.56);
            stack.Push(1.56);
            stack.Push(4.56);
            stack.Push(7.56);
            stack.PrintStack();

            //Console.WriteLine("This stack is empty {0}", stack.IsEmpty());
            //Console.WriteLine("This stack is  {0} in size", stack.Size());
            //Console.WriteLine("The last item in this stack is  {0}", stack.Peek());
            //Console.WriteLine($"{stack.Pop()} has been removed from this stack");
            //stack.PrintStack();
            //Console.WriteLine($"index of this element is {stack.IndexOf(1.56)}");
            //Console.WriteLine($"Element at index of 2 = {stack[0]}");
            stack[0] = 45.678;
            //stack.PrintStack();





















        }
    }
}
