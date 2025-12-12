using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Codibility
{
    public class CheckPermutationTask
    {
        //tests
        //permutation.Solve([2, 3, 5, 1]);
        //permutation.SolveV2([2, 3, 15, 1]);
        //permutation.SolveV2([2, 1, 15, 1, 3]);

        public bool Solve(int[] A)
        {

            var orderedArray = A.OrderBy(x => x).ToList();  

            for (int i = 0; i< orderedArray.Count; i++)
            {
                if(orderedArray[i] != i+1)
                    return false;
            }

            return true;
        }

        //solution with HashSet - get unique Data
        public bool SolveV2(int[] A)
        {
            var occurances = new HashSet<int>();

            foreach(int elem in A)
            {
                if(elem < A.Length)
                    occurances.Add(elem);
            }

            if(occurances.Count == A.Length)
                return true;
            return false;
        }

    }
}
