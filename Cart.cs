using System.Collections.Generic;
using System.Linq;

namespace GenericsTask
{
    public class Cart<T> : ICountable
    {
        public List<Box<T>> Boxes = new List<Box<T>>();

        public int Count()
        {
            return Boxes.Sum(box => box.Count());
        }
    }
}
