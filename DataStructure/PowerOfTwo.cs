using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            while (n != 0)
            {
                var lastbit = n & 1;
                n = n >> 1;
                if (lastbit == 1 && n != 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
