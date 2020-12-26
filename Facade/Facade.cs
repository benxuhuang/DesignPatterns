public class Facade
{
    private SubSystemOne _subSystemOne;
    private SubSystemTwo _subSystemTwo;
    private SubSystemThree _subSystemThree;
    public Facade()
    {
        _subSystemOne = new SubSystemOne();
        _subSystemTwo = new SubSystemTwo();
        _subSystemThree = new SubSystemThree();
    }

    public void MethodA()
    {
        _subSystemOne.MethodOne();
        _subSystemTwo.MethodTwo();
    }


    public void MethodB()
    {
        _subSystemTwo.MethodTwo();
        _subSystemThree.MethodThree();
    }
}