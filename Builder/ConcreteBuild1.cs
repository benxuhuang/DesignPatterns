public class ConcreteBuild1 : Builder
{
    public Product product = new Product();
    public override void BuildPartA()
    {
        product.Add("part a");
    }
    public override void BuildPartB()
    {
        product.Add("part b");
    }

    public override Product GetResult()
    {
        return product;
    }

}