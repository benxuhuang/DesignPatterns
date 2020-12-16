using System;

class Proxy : IGiveGift
{
    Pursuit pursuit;
    public Proxy(Girl girl)
    {
        pursuit = new Pursuit(girl);
    }

    public void GiveDolls()
    {
        pursuit.GiveDolls();
    }

    public void GiveFlowers()
    {
        pursuit.GiveFlowers();
    }

    public void GiveChocolate()
    {
        pursuit.GiveChocolate();
    }
}