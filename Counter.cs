using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public class Counter<T> : ICountable
    {

        public List<T> FruitList;
        public void Add(T Item)
        {
            FruitList.Add(Item);
        }
        public int Count()
        {
            int count = FruitList.Count;
            return count;
        }

        public int RedAppleCounter()
        {
            int count = 0;
            return count;
        }

        public int GreenAppleCounter()
        {
            int count = 0;
            return count;
        }
    }
}
    
