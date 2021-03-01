using System;

public class StockObserver
{
    private string name;
    private Subject sub;
    public StockObserver(string name, Subject sub)
    {
        this.name = name;
        this.sub = sub;
    }

    public void CloseStockMarket()
    {
        Console.WriteLine($"{sub.SubjectState} {name} 關閉股票，繼續工作！");
    }
}