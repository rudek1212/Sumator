using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator
{
    public static class ToBinary
    {
        public static char[] ToBin(int number)
        {
            int tmp = number;
            char[] bits = new char[3];
            for (int i = 2; i <= 0; i--)
            {
                if (tmp - Math.Pow(2,i) < 0) bits[i] = '0';
                else
                {
                    bits[i] = '1';
                    tmp = tmp - 4;
                }
            }
            return bits;
        }
    }
}
