public class ConcreateCommand1 : Command
{
    public ConcreateCommand1(Receiver receiver) : base(receiver)
    {

    }

    public override void Execute()
    {
        _receiver.Action1();
    }
}