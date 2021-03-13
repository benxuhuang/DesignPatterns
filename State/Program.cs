using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Work project = new Work();
            project.Hour = 9;
            project.WriteProgram();
            project.Hour = 10;
            project.WriteProgram();
            project.Hour = 12;
            project.WriteProgram();
            project.Hour = 14;
            project.WriteProgram();
            project.TaskFinished = true;
            //project.TaskFinished = false;
            project.Hour = 17;
            project.WriteProgram();
            project.Hour = 20;
            project.WriteProgram();
            project.Hour = 19;
            project.WriteProgram();
            project.Hour = 22;
            project.WriteProgram();
        }
    }
}
