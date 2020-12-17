using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("Ben");
            a.SetPersonalInfo("man","30");
            a.SetWorkExperience("2016","conmpany_a");
            a.Display();
            Resume b = (Resume)a.Clone();
            b.SetPersonalInfo("man","30");
            b.SetWorkExperience("2017","conmpany_b");
            b.Display();

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("man","30");
            c.SetWorkExperience("2018","conmpany_c");
            c.Display();
        }
    }
}
