using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Codibility
{
    public class CheckPermutationTask
    {
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
