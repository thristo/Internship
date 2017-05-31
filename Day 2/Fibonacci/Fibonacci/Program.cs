using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            // Method which print first n Fibonacci numbers. Every even number is negative


        
        }


        public static string Fibonacci ()
        {

            //1,1,2,3,5,8,13,21.....
               int length = int.Parse(Console.ReadLine());
               int first = 1;
               int second = 1;
               int third = first + second;
                first = second;
                second = third;
                int n = second + third;
                ++n = n + third;
                

               int n = (n - 2) + (n - 1);

               for (int i = 0; i < n; i++)
               {
                   Console.WriteLine(
               


                




            
            }
        
        
        
        }





    }
}
