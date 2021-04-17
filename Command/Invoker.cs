using System.Collections.Generic;

public class Invoker
{
    // private Command _command;

    private List<Command> _commandList = new List<Command>();

    public void SetCommand(Command command)
    {
        // this._command = command;
        this._commandList.Add(command);
    }

    public void RemoveCommand(Command command)
    {
        this._commandList.Remove(command);
    }

    public void ExecuteCommand()
    {
        // this._command.Execute();
        foreach (var item in this._commandList)
        {
            item.Execute();
        }

    }
}