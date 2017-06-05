using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_3__Matrix_
{
    class Program
    {

        static void Main(string[] args)
        {
            ReadMatrixFromFile();
            Console.WriteLine();
            PrintMatrixByGivenLength();
        }



        public static void ReadMatrixFromFile()
        {
            string matrixA = File.ReadAllText(@"Matrix.txt", Encoding.UTF8);
            Console.WriteLine(matrixA);

            matrixA = matrixA.ToCharArray();

            int[] newArray = new int[matrixA.Length/2]; //Convert string into int[]
            for (int i =0; i<matrixA.Length; i=i+2)
            {
               matrixA[i] = matrixA[i]- 48;
               newArray[i] = matrixA[i]; 
            }

            int[,] newMatrix;
            Buffer.BlockCopy(newArray, 0, newMatrix, 0, newArray.Length * sizeof(int)); //Convert int[] into int[,]

            Console.WriteLine("New matrix:"); //Print matrix
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                   Console.WriteLine(newMatrix[i,j]+" ");
                }
                Console.WriteLine();
            }
       }



        public static void PrintMatrixByGivenLength()
       {
            int n = int.Parse(Console.ReadLine());
            int[,] matrixB = new int[n,n];

            int row=0;
            int col = 0;
            matrixB[0,0] = 1;
            Console.Write(matrixB[0,0] + " ");
            for (row = 0; row<n-1; row++)
            {
                for (col = 0; col<n-1; col++)
                {
                    matrixB[row, col+1] = matrixB[row, col] + 1;

                    Console.Write(matrixB[row, col+1] + " ");
                }
                Console.WriteLine();
            }
       }









    }
}
