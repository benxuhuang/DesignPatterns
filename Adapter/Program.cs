using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player b = new Forwards("巴迪");
            b.Attack();

            Player m = new Guards("麥克");
            m.Attack();

            Player ym = new Translator("姚明");
            ym.Attack();
            ym.Defense();
        }
    }
}
