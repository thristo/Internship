using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3__Matrix_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            int row=0;
            int col = 0;
            matrix[0,0] = 1;
            for (row = 0; row<=n; row++)
            {
                for (col = 0; col<=n; col++)
                {
                    matrix[row, col] = matrix[0, 0]++;
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }


            /*for (row =0; row <= n; row++)
            {
                for (col = 0; col <= n; col++)
                {
                    Console.Write(matrix[row, col]+" ");

                }
                Console.WriteLine();
            }
            */

            //...




        }
    }
}
