using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Codibility
{
    public class FindBinaryGapOfZerosTask
    {
        //tests
        //int number = 9
        //int number = 1041

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
