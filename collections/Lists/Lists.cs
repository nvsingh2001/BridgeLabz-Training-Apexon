using System.Collections;

namespace collections.Lists
{
    public class Lists<T> : IEnumerable<T>
    {
        private T[] _items;
        private const int DefaultCapacity = 10;

        public int Count { get; private set; }

        public Lists() : this(DefaultCapacity) { }

        public Lists(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));

            _items = new T[capacity];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count == _items.Length)
            {
                Resize(_items.Length == 0 ? DefaultCapacity : _items.Length * 2);
            }

            _items[Count++] = item;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            int moveCount = Count - index - 1;
            if (moveCount > 0)
            {
                Array.Copy(_items, index + 1, _items, index, moveCount);
            }

            _items[--Count] = default!;
        }

        public void RemoveLast()
        {
            if (Count == 0)
                throw new InvalidOperationException("List is empty.");

            _items[--Count] = default!;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException(nameof(index));

                return _items[index];
            }
        }

        private void Resize(int newCapacity)
        {
            var newArray = new T[newCapacity];
            Array.Copy(_items, newArray, Count);
            _items = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
