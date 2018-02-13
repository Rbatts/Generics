using System;
using System.Collections.Generic;
using System.Linq;
using static GenericsTask.Apple;

namespace GenericsTask
{
    public class Counter<T> : ICountable
    {
        public List<T> AppleList = new List<T>();
        public void Add(T item) 
        {
            AppleList.Add(item);
        }

        public void AddMany(IEnumerable<T> items)
        {
            AppleList.AddRange(items);
        }

        public int Count(Func<T, bool> countRequired)
        {
            int count = AppleList.Count(countRequired);
            return count;
        }
        public int Count()
        {
            int count = AppleList.Count;
            return count;
        }

    }
}
    
 