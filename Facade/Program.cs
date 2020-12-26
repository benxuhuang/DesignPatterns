using System;

class Program
{
    static void Main(string[] args)
    {
        Facade facade = new Facade();
        Console.WriteLine("Method Group A");
        facade.MethodA();
        Console.WriteLine("Method Group B");
        facade.MethodB();
    }
}
