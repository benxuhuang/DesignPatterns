public abstract class HandSetBrand
{
    protected HandSetSoft handSetSoft;
    public void SetHandSetSoft(HandSetSoft handSetSoft)
    {
        this.handSetSoft = handSetSoft;
    }

    public abstract void Run();
}