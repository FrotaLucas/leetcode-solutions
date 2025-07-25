using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Operations
{
    public class Division : Operation
    {
        public Division() {

            TypeOperation = "/";
        }


        public override void DoOperation()
        {
            int numerator = int.Parse(Numerator1) * int.Parse(Denominator2);
            int denominator = int.Parse(Denominator1) * int.Parse(Numerator2);


            Console.WriteLine($"Division: {numerator}/{denominator}");
        }
    }
}
