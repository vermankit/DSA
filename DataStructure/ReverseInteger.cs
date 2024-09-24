using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            int reverseNumber = 0;
            while (x != 0)
            {
                var lastdigit = x % 10;
                if (reverseNumber < int.MinValue / 10
                || reverseNumber > int.MaxValue / 10)
                {
                    return 0;
                }
                reverseNumber = reverseNumber * 10 + lastdigit;
                x = x / 10;
            }

            return reverseNumber;
        }
    }
}
