using System;
public abstract class TestPaper
{
    public void Question1()
    {
        Console.WriteLine("Question1");
        Console.WriteLine(Answer1);
    }
    public abstract string Answer1()
    {
        return "default answer";
    }

    public void Question2()
    {
        Console.WriteLine("Question2");
        Console.WriteLine(Answer2);
    }

    public abstract string Answer2()
    {
        return "default answer";
    }

    public void Question3()
    {
        Console.WriteLine("Question3");
        Console.WriteLine(Answer3);
    }

    public abstract string Answer3()
    {
        return "default answer";
    }


}