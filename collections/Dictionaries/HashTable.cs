namespace collections.Dictionaries;

class Entry(Object key, Object value)
{
    public object Key { get; } = key;
    public object Value { get; set; } = value;
    public Entry? Next { get; set; }
}


public class HashTable(int capactiy = 16)
{
    private Entry[]? _buckets = new Entry[capactiy];
    private int size;
    public int Count => size;

    private int GetIndex(Object key)
    {
        int hash = key.GetHashCode();
        return Math.Abs(hash % _buckets.Length);
    }

    public void Put(Object key, Object value)
    {
        int index = GetIndex(key);
        
        Entry? head = _buckets[index];
        Entry? current = head;

        while (current != null)
        {
            if (key.Equals(current.Key))
            {
                current.Value = value;
                return;
            }
            current = current.Next;
        }

        Entry newEntry = new Entry(key, value)
        {
            Next = head
        };
        
        _buckets[index] = newEntry;
        size++;
    }

    public Object? Get(Object key)
    {
        int index = GetIndex(key);
        Entry? current = _buckets[index];

        while (current != null)
        {
            if (key.Equals(current.Key))
            {
                return current.Value;
            }
            current = current.Next;
        }

        return null;
    }

    public bool Remove(Object key)
    {
        int index = GetIndex(key);
        Entry? current = _buckets[index];
        Entry? previous = null;

        while (current != null)
        {
            if (key.Equals(current.Key))
            {
                if (previous == null)
                {
                    _buckets[index] = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                }

                size--;
                return true;
            }
            previous = current;
            current = current.Next;
        }
        return false;
    }
}