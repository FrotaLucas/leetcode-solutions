using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Codibility
{
    // list of integers no nullable
    public class FindMissingInteger
    {
        public int Solve(int[]A)
        {
            var n  = A.Length;
            var upperSummup = (n +1)* (n + 1 + 1) / 2;

            var realSummup = A.Sum();

            var missingValue = upperSummup - realSummup;

            return missingValue;

        }
    }
}
