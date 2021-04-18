using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler1 = new ConcreateHandler1();
            Handler handler2 = new ConcreateHandler2();
            Handler handler3 = new ConcreateHandler3();

            handler1.SetHandler(handler2);
            handler2.SetHandler(handler3);

            Request request1 = new Request() { Type = "A", Number = 50 };
            handler1.HandleRequest(request1);

            Request request2 = new Request() { Type = "A", Number = 15 };
            handler1.HandleRequest(request2);

        }
    }
}
