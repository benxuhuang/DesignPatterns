using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receiver 實作實際執行動作
            Receiver receiver = new Receiver();
            //ConcreateCommand 將Receiver與Action綁定成一個通知命令 
            Command command1 = new ConcreateCommand1(receiver);
            Command command2 = new ConcreateCommand2(receiver);
            //透過 Invoker 設定要執行的命令與通知Receiver執行命令
            Invoker invoker = new Invoker();

            invoker.SetCommand(command1);
            // invoker.ExecuteCommand();

            invoker.SetCommand(command2);
            invoker.ExecuteCommand();
        }
    }
}
