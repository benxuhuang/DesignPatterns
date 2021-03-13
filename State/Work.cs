public class Work
{
    private State current;
    public double Hour { get; set; }
    public bool TaskFinished { get; set; }
    public Work()
    {
        current = new ForenoonState();
    }

    public void SetState(State s)
    {
        current = s;
    }

    public void WriteProgram()
    {
        current.WriteProgram(this);
    }

}