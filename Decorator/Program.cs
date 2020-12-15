using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ben");
            TShirts ts = new TShirts();
            BigTrouser bt = new BigTrouser();
            ts.Decorate(p);
            bt.Decorate(ts);
            bt.Show();
        }
    }
}
