using System.Collections.Generic;
using System.Linq;

namespace GenericsTask
{

    public class Box<T> : ICountable
    {
        List<T> Items = new List<T>();

        public void Add(T item)
        {
            Items.Add(item);
        }

        public void Add(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        public int Count()
        {
            return Items.Count();
        }
    }
}
