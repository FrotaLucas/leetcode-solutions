using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Codibility
{
    public class FindSmallestTask
    {
        //T3 find the smallest
        // This is a demo task.

        // Write a function:

        // class Solution { public int solution(int[] A); }

        // that, given an array A of N integers, returns the smallest missing positive integer (greater than 0) that does not occur in A.

        // For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

        // Given A = [1, 2, 3], the function should return 4.

        // Given A = [−1, −3], the function should return 1.

        // Write an efficient algorithm for the following assumptions:

        // N is an integer within the range [1..100,000];
        // each element of array A is an integer within the range [−1,000,000..1,000,000].
        
        //NOTES:  should be missisng only 1 single number!!
       
        //int[] A = new int[] { 1, 2, 3, 5, 7, 6 };
        public int Solve(int[] A)
        {
            //var sortedArray = A.Order();
            var sortedArray = A.Order().Where( x => x > 0 ).ToArray();


            for (int i = 0; i< sortedArray.Length-1; i++)
            {
                if (A[i + 1] - A[i] > 1 && A[i] >=0)
                    return A[i] + 1;
            }

            return sortedArray.Length+1;
        }

        //better performance
        public int SolveV2(int[] A)
        {
            var occurances = new HashSet<int>();    

            foreach(var elem in A)
            {
                if(elem>=0)
                    occurances.Add(elem);
            }

            for (int i = 0; i< occurances.Count; i++)
            {
                //Order(1) good performance
                if (!occurances.Contains(i))
                    return i;
            }

            return occurances.Count;
        }
    }
}
