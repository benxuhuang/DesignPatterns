public class RoleStateMemento
{
    public int Vit { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }

    public RoleStateMemento(int vit, int atk, int def)
    {
        this.Vit = vit;
        this.Atk = atk;
        this.Def = def;
    }
}