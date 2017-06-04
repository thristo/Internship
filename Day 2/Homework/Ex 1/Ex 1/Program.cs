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
           Console.WriteLine(MathProblems.SumBinaryRepresentations(16, 17));
           Console.WriteLine(MathProblems.SumBinaryRepresentations(13, 19, 23));
        }
    }
}

