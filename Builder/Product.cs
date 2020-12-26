using System;
using System.Collections.Generic;
public class Product
{
    List<string> parts = new List<string>();

    public void Add(string part)
    {
        parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("\n 產品 建立 ----");
        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
    }
}