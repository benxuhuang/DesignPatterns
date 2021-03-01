using System;

public class NBAObserver
{
    private string name;
    private Subject sub;
    public NBAObserver(string name, Subject sub)
    {
        this.name = name;
        this.sub = sub;
    }

    public void CloseNBADirectSeeding()
    {
        Console.WriteLine($"{sub.SubjectState} {name} 關閉NBA直撥，繼續工作！");
    }
}