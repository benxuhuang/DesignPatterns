using System;
class ForeignCenter
{
    public string Name { get; set; }
    public void 進攻()
    {
        Console.WriteLine($"外籍中鋒{this.Name}進攻");
    }

    public void 防守()
    {
        Console.WriteLine($"外籍中鋒{this.Name}防守");
    }
}