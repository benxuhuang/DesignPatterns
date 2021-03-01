using System;

public delegate void EventHandler();

public class Boss : Subject
{
    public event EventHandler Update;

    private string action;
    public void Notify()
    {
        Update();
    }

    public string SubjectState
    {
        get { return action; }
        set { action = value; }
    }

}