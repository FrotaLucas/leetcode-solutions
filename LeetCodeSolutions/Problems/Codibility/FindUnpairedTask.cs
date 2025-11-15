using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Codibility
{
    public class FindUnpairedTask
    {
        //list A with non nullable
        public int Solve(int[]A)
        {
            int n = (A.Length -1)/ 2;
            var upperSummup = 2 * (1 + n) * (1 + 1 + n) / 2;


            var realSummup = A.Sum();

            return upperSummup - realSummup;

        }
    }
}
