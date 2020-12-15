using System;

public class Person
{
    private string _name;
    public Person() { }
    public Person(string name)
    {
        this._name = name;
    }
    public virtual void Show()
    {
        Console.WriteLine("{0} is decorated", this._name);
    }
}