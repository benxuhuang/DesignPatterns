using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreateAggregate a = new ConcreateAggregate();
            a[0] = "A";
            a[1] = "B";
            a[2] = "C";

            // Iterator i = new ConcreateIterator(a);
            Iterator i = new ConcreateIteratorDesc(a);

            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine($"Hi {i.CurrentItem()}");
                i.Next();
            }
        }
    }
}
