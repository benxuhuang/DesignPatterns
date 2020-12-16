using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var girl = new Girl("Judy");
            Proxy proxy = new Proxy(girl);
            proxy.GiveDolls();
            proxy.GiveFlowers();
            proxy.GiveChocolate();
        }
    }
}
