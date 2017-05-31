using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter two numbers:");
            int firstDecimal = int.Parse(Console.ReadLine());
            int secondDecimal = int.Parse(Console.ReadLine());

            string firstBinary = null;
            //Converting decimal to binary
            while (firstDecimal > 0)
            {
                firstDecimal = firstDecimal / 2;
                int remainder = firstDecimal % 2;
                firstBinary = firstBinary + remainder.ToString();
            }
            Console.WriteLine(/*int.Parse(*/"binary: " + firstBinary);

            string secondBinary = null;
            while (secondDecimal > 0)
            {
                secondDecimal = secondDecimal / 2;
                int remainderTwo = secondDecimal % 2;
                secondBinary = secondBinary + remainderTwo.ToString();
            }
            Console.WriteLine("binary: " + secondBinary);



            int.Parse(firstBinary);
            int.Parse(secondBinary);

            int[] firstArray;
            for (int i = 0; i < 20; i++)
            {
                firstArray[i] = firstBinary % 10;
            }

            int sum = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                sum = sum + firstArray[i];
            }
            //...


             


          }





        }
    }

