using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using LeetCodeSolutions.Problems.TdaRationalV2.Operations;

namespace LeetCodeSolutions.Problems.TdaRationalV2
{
    public class TdaRationalTaskV2
    {
        public string Inputs = "4; 1 / 2 + 3 / 4; 2 / 3 * 4 / 5; 6 / 8 - 1 / 4; 5 / 6 / 7 / 8";
        public TdaRationalTaskV2()
        {
            
        }

        public void Solve()
        {

            var calculation = new Calculation();

            //substituicao de LISKOV
            calculation.Operation = new Addition();

            var result1 = calculation.Operation;
            result1.DoOperation();

        }
    }
}
