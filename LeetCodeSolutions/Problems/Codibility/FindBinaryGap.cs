using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Codibility
{
    public class FindBinaryGap
    {
        public void Solve(int number)
        {
            var arrayOfZeros = ConvertIntegerToBinary(number).Split("1");



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
