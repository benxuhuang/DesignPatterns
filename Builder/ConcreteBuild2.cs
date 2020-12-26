public class ConcreteBuild2 : Builder
{
    public Product product = new Product();
    public override void BuildPartA()
    {
        product.Add("part x");
    }
    public override void BuildPartB()
    {
        product.Add("part y");
    }

    public override Product GetResult()
    {
        return product;
    }

}