using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Codibility
{
    public class CheckPermutation
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


    }
}
