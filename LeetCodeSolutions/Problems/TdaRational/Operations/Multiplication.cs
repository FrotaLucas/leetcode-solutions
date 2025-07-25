using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.TdaRational.Operations
{
    public class Multiplication : Operation
    {

        public Multiplication() {
            TypeOperation = "*";
        }


        public override void DoOperation()
        {
            int numerator = int.Parse(Numerator1) * int.Parse(Numerator2);
            var denominator = int.Parse(Denominator1) * int.Parse(Denominator2);

            Console.WriteLine($"Multiplication: {numerator}/{denominator}");
        }
    }
}
