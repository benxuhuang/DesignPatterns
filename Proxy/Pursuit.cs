using System;

class Pursuit : IGiveGift
{
    private Girl _girl;
    public Pursuit(Girl girl)
    {
        this._girl = girl;
    }

    public void GiveDolls()
    {
        Console.WriteLine(_girl.Name + "got a doll");
    }

    public void GiveFlowers()
    {
        Console.WriteLine(_girl.Name + "got a flower");
    }

    public void GiveChocolate()
    {
        Console.WriteLine(_girl.Name + "got a chocolate");
    }
}