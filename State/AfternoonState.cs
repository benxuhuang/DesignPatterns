using System;

public class AfternoonState : State
{
    public override void WriteProgram(Work w)
    {
        if (w.Hour < 17)
        {
            Console.WriteLine($"當前時間: {w.Hour} 點，下午繼續工作！");
        }
        else
        {
            w.SetState(new EveningState());
            w.WriteProgram();
        }
    }
}