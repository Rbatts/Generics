using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{ 
    public class Counter<T> : ICountable
    {
        private List<T> FruitList;
        public void Add(T Item)
        {
            FruitList.Add(Item);
        }

        public int Count()
        {
            int count = FruitList.Count;
            return count;
        }
    }
}
    
