using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2__Fibonacci_
{
    public class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciSequence(length));
        }


        public static string FibonacciSequence(int length)
        {
            //Fibonacci
            //0,1,1,2,3,5,8,13,21....
            // Program that prints first N items of Fibonacci sequence. N is entered by user
            int first = 0;
            int second = 1;
            int third = 1;
            string sequence = "";
            sequence = first.ToString() + "," + second;


            for (int i = 0; i < length; i++)
            {
                sequence = sequence + ",";
                third = first + second;
                first = second;
                second = third;

                //Every even number negative
                if (third % 2 == 0)
                {
                    third = third * -1;
                    // third = third - 2 * third; also works?
                }
                sequence = sequence + third;

            }
            return sequence;
        }

    }
}
