using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Ifactory factory = new UndergraduateFactory();
            Nightingale student = factory.CreateNiahtingale();
            student.BuyRice();
            student.Sweep();
            student.Wash();
        }
    }
}
