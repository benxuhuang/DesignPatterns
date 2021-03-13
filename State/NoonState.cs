using System;
public class NoonState : State
{
    public override void WriteProgram(Work w)
    {
        if (w.Hour < 13)
        {
            Console.WriteLine($"當前時間: {w.Hour} 點，午飯與午休！");
        }
        else
        {
            w.SetState(new AfternoonState());
            w.WriteProgram();
        }
    }
}