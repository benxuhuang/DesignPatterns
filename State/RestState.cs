using System;
public class RestState : State
{
    public override void WriteProgram(Work w)
    {
        Console.WriteLine($"當前時間: {w.Hour} 點，下班回家摟！");
    }
}