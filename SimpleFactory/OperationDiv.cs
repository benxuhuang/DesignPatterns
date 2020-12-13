public class OperationDiv : Operation
{
    public override double GetResult()
    {
        double result = 0;
        if (NumberB == 0)
            throw new System.Exception("除數不能為0");
        result = NumberA / NumberB;
        return result;
    }
}