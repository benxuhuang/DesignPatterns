public abstract class Handler
{
    protected Handler _nextHandler;

    public void SetHandler(Handler nextHander)
    {
        _nextHandler = nextHander;
    }

    public abstract void HandleRequest(Request request);

}