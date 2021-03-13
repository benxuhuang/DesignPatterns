using System;
class Forwards : Player
{
    public Forwards(string name) : base(name)
    {

    }

    public override void Attack()
    {
        Console.WriteLine($"前鋒{name}進攻");
    }

    public override void Defense()
    {
        Console.WriteLine($"前鋒{name}防守");
    }


}