using System;

namespace Stratege
{
    class Program
    {
        static void Main(string[] args)
        {
            CashContext cc;
            double totalPrice = 0d;

            cc = new CashContext("normal");
            totalPrice = cc.GetResult(700);
            Console.WriteLine("Normal Total Price: {0}", totalPrice);

            cc = new CashContext("cashRetuen");
            totalPrice = cc.GetResult(700);
            Console.WriteLine("CashRetuen Total Price: {0}", totalPrice);

            cc = new CashContext("cashRebate");
            totalPrice = cc.GetResult(700);
            Console.WriteLine("CashRebate Total Price: {0}", totalPrice);
        }
    }
}
