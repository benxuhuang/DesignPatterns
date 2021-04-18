using System;
public class ConcreateHandler3 : Handler
{
    public override void HandleRequest(Request request)
    {
        if (request.Type == "A" && request.Number > 20)
        {
            Console.WriteLine($"{this.GetType().Name} approved type:{request.Type} number:{request.Number} request!");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}