﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();
        Builder b1 = new ConcreteBuild1();
        Builder b2 = new ConcreteBuild2();
        director.Construct(b1);
        Product p1 = b1.GetResult();
        p1.Show();
        director.Construct(b2);
        Product p2 = b2.GetResult();
        p2.Show();
    }
}
