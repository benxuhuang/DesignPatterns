using System;
class Translator : Player
{
    private ForeignCenter wjzf = new ForeignCenter();
    public Translator(string name) : base(name)
    {
        wjzf.Name = name;
    }

    public override void Attack()
    {
        wjzf.進攻();
    }

    public override void Defense()
    {
        wjzf.防守();
    }
}