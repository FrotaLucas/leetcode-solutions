using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Operations
{
    public class Addition : Operation
    {
        public Addition("+", string numerator1, string numerator2) : base(typeOperation, numerator1, numerator2) { }

        public override void DoOperation()
        {

            int sum = int.Parse(Numerator1 + Numerator2);

            Console.WriteLine("sum:" + sum);
        }
    }
}
