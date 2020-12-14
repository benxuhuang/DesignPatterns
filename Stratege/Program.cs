using System;

namespace Stratege
{
    class Program
    {
        static void Main(string[] args)
        {
            CashContext cc = new CashContext("cashRebate");
            double totalPrice = cc.GetResult(500);
            Console.WriteLine("Total Price: {1}", totalPrice);
        }
    }
}
