using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.TdaRationalV2.Operations
{
    public class Addition : Operation
    {
        public Addition()
        {
            TypeOperation = "+";
        }
        public override void DoOperation()
        {
            Console.WriteLine("execute addition ");
        }
    }
}
