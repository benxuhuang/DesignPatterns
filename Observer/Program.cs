using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            StockObserver emp1 = new StockObserver("emp1", boss);
            NBAObserver emp2 = new NBAObserver("emp2", boss);
            boss.Update += new EventHandler(emp1.CloseStockMarket);
            boss.Update += new EventHandler(emp2.CloseNBADirectSeeding);

            boss.SubjectState = "老闆我回來了！";
            boss.Notify();
        }
    }
}
