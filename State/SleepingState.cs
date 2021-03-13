using System;
public class SleepingState : State
{
    public override void WriteProgram(Work w)
    {
        Console.WriteLine($"當前時間: {w.Hour} 點，加班加到睡著了！");
    }
}