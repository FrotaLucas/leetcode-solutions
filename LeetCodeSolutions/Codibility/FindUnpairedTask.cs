using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Codibility
{
    public class FindUnpairedTask
    {
        //tests

        //int[] A = [2, 3, 1, 4, 4, 1, 3];
        //int [] A = [2, 3, 1, 4, 2, 5, 4, 1, 3];




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
