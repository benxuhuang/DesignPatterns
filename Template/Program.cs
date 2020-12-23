using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPaper testPaper = new TestPaperA();
            testPaper.Question1();
            testPaper.Question2();
            testPaper.Question3();
            testPaper = new TestPaperB();
            testPaper.Question1();
            testPaper.Question2();
            testPaper.Question3();
        }
    }
}
