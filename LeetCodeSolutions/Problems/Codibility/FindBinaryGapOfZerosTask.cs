using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Codibility
{
    public class FindBinaryGapOfZerosTask
    {
        public int Solve(int number)
        {
            var arrayOfZeros = ConvertIntegerToBinary(number).Split("1");

            int totZeros = 0;
            foreach(var group in arrayOfZeros)
            {
                if (group.Length > totZeros)
                    totZeros = group.Length;
            }

            return totZeros;

        }

        //less verbosity
        public int SolveV2(int number)
        {
            var arrayOfZeros = ConvertIntegerToBinary(number).Split("1");

            var totZeros = arrayOfZeros.Max(x => x.Length); 

            return totZeros;
        }

        public string ConvertIntegerToBinary(int number) 
        {
            string result = string.Empty;

            while(number > 0)
            {
                var binaryDigit = number % 2;
                number = number / 2;

                result = binaryDigit + result;
            }
        

            return result;
        }

    }
}
