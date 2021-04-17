public class ConcreateCommand2 : Command
{
    public ConcreateCommand2(Receiver receiver) : base(receiver)
    {

    }

    public override void Execute()
    {
        _receiver.Action2();
    }
}