public class CashContext
{
    CashSuper cs = null;
    public CashContext(string type)
    {
        //simple factory pattern
        switch (type)
        {
            case "normal":
                cs = new CashNormal();
                break;
            case "cashRetuen":
                cs = new CashReturn(300, 100);
                break;
            case "cashRebate":
                cs = new CashRebate(0.8);
                break;
        }
    }

    public double GetResult(double money)
    {
        return cs.acceptCash(money);
    }
}