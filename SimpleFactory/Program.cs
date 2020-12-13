using System;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.createOperate("+");
            oper.NumberA = 5;
            oper.NumberB = 10;
            var result = oper.GetResult();
            Console.Write(result);
        }
    }
}
