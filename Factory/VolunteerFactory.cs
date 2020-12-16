public class VolunteerFactory : Ifactory
{
    public Nightingale CreateNiahtingale()
    {
        return new Volunteer();
    }
}