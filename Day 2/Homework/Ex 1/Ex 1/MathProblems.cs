using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    public class MathProblems
    {
        public static int SumBinaryRepresentations(uint a, uint b)
        {
            return SumBinaryRepresentations(a) + SumBinaryRepresentations(b);
        }

        public static int SumBinaryRepresentations(uint a, uint b, uint c)
        {
            return SumBinaryRepresentations(a, b) + SumBinaryRepresentations(c);
        }

        public static int SumBinaryRepresentations(uint a, uint b, uint c, uint d)
        {
            return SumBinaryRepresentations(a, b, c) + SumBinaryRepresentations(a);
        }

        private static int SumBinaryRepresentations(uint a)
        {
            StringBuilder thirdBinary = new StringBuilder();
            uint system = 2;
            while (a > 0)
            {
                uint remainder = a % system;
                a = a / system;
                thirdBinary = thirdBinary.Append(remainder.ToString());
            }

            int sum = 0;
            for (int i = 0; i < thirdBinary.Length; i++)
            {
                sum += thirdBinary[i] - 48;
            }
            return sum;
        }

        private static StringBuilder ReverseString(StringBuilder s)
        {
            var c = s.ToString().ToCharArray();
            Array.Reverse(c);
            return new StringBuilder(new string(c));
        }
    }
}
