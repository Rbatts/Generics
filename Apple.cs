using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public class Apple : ICountable
    {
        public AppleColour Colour;

        public enum AppleColour
        {
            RedApple = 1,
            GreenApple = 2
        };

        public int Count()
        {
            return 1;
        }
    }

}
