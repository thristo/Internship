using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    public class MathProblems
    {
        public static int SumBinaryRepresentations(int a, int b)
        {
            int firstDecimal = a;
            int secondDecimal = b;
            StringBuilder firstBinary = new StringBuilder();
            StringBuilder secondBinary = new StringBuilder();
            while (firstDecimal > 0)
            {
                int remainder = firstDecimal % 2;
                firstDecimal = firstDecimal / 2;
                firstBinary = firstBinary.Append(remainder.ToString());
            }
            while (secondDecimal > 0)
            {
                int remainderTwo = secondDecimal % 2;
                secondDecimal = secondDecimal / 2;
                secondBinary = secondBinary.Append(remainderTwo.ToString());
            }

            int sum = 0;
            for (int i = 0; i < firstBinary.Length; i++)
            {
                sum += firstBinary[i] - 48;
            }
            for (int i = 0; i < secondBinary.Length; i++)
            {
                sum += secondBinary[i] - 48;
            }
            return sum;
        }

        private StringBuilder ReverseString(StringBuilder s)
        {
            var c = s.ToString().ToCharArray();
            Array.Reverse(c);
            return new StringBuilder(new string(c));
        }
    }
}
