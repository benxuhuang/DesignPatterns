using System;
public class EveningState : State
{
    public override void WriteProgram(Work w)
    {
        if (w.TaskFinished)
        {
            w.SetState(new RestState());
            w.WriteProgram();
        }
        else
        {
            if (w.Hour < 21)
            {
                Console.WriteLine($"當前時間: {w.Hour} 點，加班中！");
            }
            else
            {
                w.SetState(new SleepingState());
                w.WriteProgram();
            }
        }
    }
}