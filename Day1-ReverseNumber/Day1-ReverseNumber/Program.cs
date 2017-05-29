using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            // Да се въведе число от потребителя, числото да се обърне
            //1234
            int number = int.Parse(Console.ReadLine());
            int reverseNumber = 0;

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
