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
            uint firstDecimal = a;
            uint secondDecimal = b;
            StringBuilder firstBinary = new StringBuilder();
            StringBuilder secondBinary = new StringBuilder();
            while (firstDecimal > 0) //превръщаме числото от int в string
            {
                uint remainder = firstDecimal % 2;
                firstDecimal = firstDecimal / 2;
                firstBinary = firstBinary.Append(remainder.ToString());
            }
            while (secondDecimal > 0) //превръщаме числото от int в string
            {
                uint remainderTwo = secondDecimal % 2;
                secondDecimal = secondDecimal / 2;
                secondBinary = secondBinary.Append(remainderTwo.ToString());
            }

            /*ReverseString(firstBinary); --> produces error
            ReverseString(secondBinary); --> produces error
            Console.WriteLine("FirstBinary= " + firstBinary);
            Console.WriteLine("SecondBinary= " + secondBinary);
            */

            int sum = 0; //получаваме сумата на цифрите
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
    



    public static int SumBinaryRepresentationsOfThree(uint a, uint b, uint c)
    {
            uint firstDecimal = a;
            uint secondDecimal = b;
            uint thirdDecimal = c;
            StringBuilder firstBinary = new StringBuilder();
            StringBuilder secondBinary = new StringBuilder();
            StringBuilder thirdBinary = new StringBuilder();
            while (firstDecimal > 0) //превръщаме числото от int в string
            {
                uint remainder = firstDecimal % 2;
                firstDecimal = firstDecimal / 2;
                firstBinary = firstBinary.Append(remainder.ToString());
            }
            while (secondDecimal > 0) //превръщаме числото от int в string
            {
                uint remainderTwo = secondDecimal % 2;
                secondDecimal = secondDecimal / 2;
                secondBinary = secondBinary.Append(remainderTwo.ToString());
            }
            while (thirdDecimal > 0)
            {
                uint remainderThree = thirdDecimal % 2;
                thirdDecimal = thirdDecimal / 2;
                thirdBinary = thirdBinary.Append(remainderThree.ToString());
            }
            
            int sum = 0; //получаваме сумата на цифрите
            for (int i = 0; i < firstBinary.Length; i++)
            {
                sum += firstBinary[i] - 48;
            }
            for (int i = 0; i < secondBinary.Length; i++)
            {
                sum += secondBinary[i] - 48;
            }
            for (int i = 0; i < thirdBinary.Length; i++)
            {
                sum = sum + thirdBinary[i] - 48;
            }
            return sum;
        }

       


    }
}
