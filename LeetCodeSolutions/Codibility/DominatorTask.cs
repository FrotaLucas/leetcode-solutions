using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace LeetCodeSolutions.Codibility
{

//    An array A consisting of N integers is given.The dominator of array A is the value that occurs in more than half of the elements of A.
//    For example, consider array A such that

// A[0] = 3    A[1] = 4    A[2] = 3
// A[3] = 2    A[4] = 3    A[5] = -1
// A[6] = 3    A[7] = 3
//The dominator of A is 3 because it occurs in 5 out of 8 elements of A (namely in those with indices 0, 2, 4, 6 and 7)
//and 5 is more than a half of 8.

//Write a function
//    class Solution { public int solution(int[] A); }
//    that, given an array A consisting of N integers, returns index of any element of array A in which the dominator
//    of A occurs.The function should return −1 if array A does not have a dominator.
//    For example, given array A such that
//    A[0] = 3    A[1] = 4    A[2] = 3


//     A[3] = 2    A[4] = 3    A[5] = -1


//     A[6] = 3    A[7] = 3
//    the function may return 0, 2, 4, 6 or 7, as explained above.


//    Write an efficient algorithm for the following assumptions:


//    N is an integer within the range[0..100, 000];
//    each element of array A is an integer within the range[−2, 147, 483, 648..2, 147, 483, 647].
    public class DominatorTask
    {
        //tests
        int[] A = [3, 4, 3, 2, 3, -1, 3, 3];
        int[] B = [3, 3, 3, 2, 2];
        int[] C = [2, 2, 3, 3, 3];
        int[] D = [2, 2, 1, 3, 3]; //false because 3 does not occur more oft than the marjorit
        //solution O(n * log n)
        public int Solve(int[] A)
        {
            int dominator = -1;

            //log n
            Array.Sort(A);

            //index 1 slice
            int index = A.Length / 2;

            int i = 0;
            int count = 0;
            int num = A[0];

            while (i < A.Length)
            {

                if(num != A[i])
                {
                    if(count > dominator)
                    {
                        dominator = count;
                        count = 0;
                    }
                }

                if(i < A.Length -1 && A[i] == A[i+1])
                {
                    num = A[i]; 
                    count = count + 2;
                    i++;

                }

               
                i++;
            }
            
            if(count == 0 && dominator == 0)
                return -1;

            return dominator;
        }


        //solution O(n^ 2)
        public int Solve2(int[] A)
        {
            int dominator = 0;



            return dominator;
        }
    }
}
