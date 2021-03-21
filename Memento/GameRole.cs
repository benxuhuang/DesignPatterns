using System;

public class GameRole
{
    public int Vitality { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public void StateDisplay()
    {
        Console.WriteLine($"角色當前狀態:");
        Console.WriteLine($"生命力:{this.Vitality}");
        Console.WriteLine($"攻擊力:{this.Attack}");
        Console.WriteLine($"防禦力:{this.Defense}");
        Console.WriteLine($"");
    }

    public void SetInitState()
    {
        this.Vitality = 100;
        this.Attack = 100;
        this.Defense = 100;
    }

    public void Fight()
    {
        this.Vitality = 0;
        this.Attack = 0;
        this.Defense = 0;
    }

    public RoleStateMemento SaveState()
    {
        return new RoleStateMemento(Vitality, Attack, Defense);
    }

    public void RecoveryState(RoleStateMemento memento)
    {
        this.Vitality = memento.Vit;
        this.Attack = memento.Atk;
        this.Defense = memento.Def;
    }

}