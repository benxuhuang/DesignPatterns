public class ConcreateIteratorDesc : Iterator
{
    private ConcreateAggregate aggregate;
    private int current = 0;

    public ConcreateIteratorDesc(ConcreateAggregate aggregate)
    {
        this.aggregate = aggregate;
        current = aggregate.Count - 1;
    }

    public override object First()
    {
        return aggregate[aggregate.Count - 1];
    }

    public override object Next()
    {
        object ret = null;
        current--;
        if (current >= 0)
        {
            ret = aggregate[current];
        }
        return ret;
    }

    public override bool IsDone()
    {
        return current < 0;
    }

    public override object CurrentItem()
    {
        return aggregate[current];
    }

}