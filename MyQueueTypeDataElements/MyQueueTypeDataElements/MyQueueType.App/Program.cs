using System;

namespace MyQueueType.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Stact---------------");
            MyQueue que = new MyQueue();

            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue("a");
            que.Enqueue("b");
            que.Enqueue("c");

            Console.WriteLine("Count:"+que.Count);
            Console.WriteLine("Count:"+que.Length);

            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Dequeue());


            var a = que.Clone();
            Console.WriteLine("->que.Clone()");
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.WriteLine(a[i].ToString());
            }



            Console.WriteLine("-------------Stact---------------");
            MyStack stack = new MyStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            Console.WriteLine("Count:" + stack.Count);
            Console.WriteLine("Count:" + stack.Length);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine("Count:" + stack.Count);
            Console.WriteLine("Count:" + stack.Length);

            var ab = stack.Clone();
            Console.WriteLine("->stack.Clone()");
            for (int i = 0; i < ab.Length - 1; i++)
            {
                Console.WriteLine(ab[i].ToString());
            }
        }
    }
}
