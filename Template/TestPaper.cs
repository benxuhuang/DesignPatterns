using System;
public abstract class TestPaper
{
    public void Question1()
    {
        Console.WriteLine("Question1");
        Console.WriteLine(Answer1);
    }

    public abstract void Answer1()
    {
        Console.WriteLine("default answer");
    }
    public void Question2()
    {
        Console.WriteLine("Question2");
        Console.WriteLine(Answer2);
    }

    public abstract void Answer2()
    {
        Console.WriteLine("default answer");
    }

    public void Question3()
    {
        Console.WriteLine("Question3");
        Console.WriteLine(Answer3);
    }

    public abstract void Answer3()
    {
        Console.WriteLine("default answer");
    }


}