using System;

namespace Sumator
{
    public static class BinaryLogic
    {
        public static char[] IntToBin(int number)
        {
            var tmp = number;
            var bits = new char[4];
            for (var i = 3; i >= 0; i--)
                if (tmp - Math.Pow(2, i) < 0)
                {
                    bits[i] = '0';
                }
                else
                {
                    bits[i] = '1';
                    tmp = tmp - (int) Math.Pow(2, i);
                }
            Array.Reverse(bits);
            return bits;
        }

        /// <summary>
        /// Returns true or false depending on character.
        /// </summary>
        /// <param name="c">0 or 1</param>
        /// <returns></returns>
        public static bool TrueOrFalse(char c)
        {
            if (c == '0') return false;
            if (c == '1') return true;
            throw new Exception("Invalid binary format");
        }

        public static char TrueOrFalse(bool value)
        {
            if (value) return '1';
            return '0';
        }
    }
}