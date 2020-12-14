public class CashRebate : CashSuper
{
    private double moneyRebate = 0d;

    public CashRebate(double moneyRebate)
    {
        this.moneyRebate = moneyRebate;
    }

    public override double acceptCash(double money)
    {
        return money * moneyRebate;
    }
}