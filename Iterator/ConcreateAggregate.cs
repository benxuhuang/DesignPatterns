using System.Collections.Generic;

public class ConcreateAggregate : Aggregate
{
    private IList<object> items = new List<object>();

    public override Iterator CreateIterator()
    {
        return new ConcreateIterator(this);
    }

    public int Count
    {
        get { return items.Count; }
    }

    public object this[int index]
    {
        get
        {
            return items[index];
        }
        set
        {
            items.Insert(index, value);
        }
    }
}