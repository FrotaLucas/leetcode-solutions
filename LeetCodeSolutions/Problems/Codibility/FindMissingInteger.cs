using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Codibility
{
    // list of integers no nullable
    public class FindMissingInteger
    {
        public int Solve(int[]A)
        {
            var n  = A.Length;
            var refSummUp = n * (n + 1) / 2;

            var realSummup = A.Sum();

            var missingValue = refSummUp - realSummup;

            return missingValue;

        }
    }
}
