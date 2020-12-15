public class Finery : Person
{
    protected Person component;
    public Finery(Person component)
    {
        this.component = component;
    }

    public override void Show()
    {
        if (component != null)
            component.Show();
    }

}