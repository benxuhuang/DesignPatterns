public class UndergraduateFactory : Ifactory
{
    public Nightingale CreateNiahtingale()
    {
        return new Undergraduate();
    }
}