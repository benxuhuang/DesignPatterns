public class ConcreateIterator : Iterator
{
    private ConcreateAggregate aggregate;
    private int current = 0;

    public ConcreateIterator(ConcreateAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public override object First()
    {
        return aggregate[0];
    }

    public override object Next()
    {
        object ret = null;
        current++;
        if (current < aggregate.Count)
        {
            ret = aggregate[current];
        }
        return ret;
    }

    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }

    public override object CurrentItem()
    {
        return aggregate[current];
    }

}