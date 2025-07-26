using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using LeetCodeSolutions.Problems.TdaRationalV2.Operations;

namespace LeetCodeSolutions.Problems.TdaRationalV2
{
    public class TdaRational
    {
        public TdaRational()
        {
            
        }


        public void PrintResult()
        {

            var calculation = new Calculation();

            //substituicao de LISKOV
            calculation.Operation = new Addition();

            var result1 = calculation.Operation;
            result1.DoOperation();

            Console.WriteLine("teste");
        }
    }
}
