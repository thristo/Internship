using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_ReverseInt.MaxValue__Homework_
{
    class Program
    {
        static void Main(string[] args)
        {

            // Да се обърне числото int.MaxValue
            int number = int.MaxValue;
            long reverseNumber = 0;

            while (number > 0)
            {
                int last = 0;
                last = number % 10;
                number = number / 10;
                reverseNumber = reverseNumber * 10 + last;
            }
            Console.WriteLine(reverseNumber);
            
        }
    }
}
