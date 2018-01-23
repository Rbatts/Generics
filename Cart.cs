using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public class Cart<T> : ICountable
    {
        public List<Box<T>> boxes = new List<Box<T>>();

        public int Count()
        {
            return boxes.Sum(box => box.Count());
        }
    }
}
