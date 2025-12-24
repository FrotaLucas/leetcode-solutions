using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSolutions.Codibility
{
//    A non-empty array A consisting of N integers is given.

//    The leader of this array is the value that occurs in more than half of the elements of A.

//    An equi leader is an index S such that 0 ≤ S<N − 1 and two sequences A[0], A[1], ..., A[S] and A[S + 1], A[S + 2], ..., A[N − 1]
//    have leaders of the same value.

//    For example, given array A such that:

//        A[0] = 4
    
//        A[1] = 3
    
//        A[2] = 4
    
//        A[3] = 4
    
//        A[4] = 4
    
//        A[5] = 2
//    we can find two equi leaders:

//0, because sequences: (4) and (3, 4, 4, 4, 2) have the same leader, whose value is 4.
//2, because sequences: (4, 3, 4) and (4, 4, 2) have the same leader, whose value is 4.
//The goal is to count the number of equi leaders.

//Write a function:

//class Solution { public int solution(int[] A); }

//    that, given a non-empty array A consisting of N integers, returns the number of equi leaders.

//    For example, given:

//        A[0] = 4
    
//        A[1] = 3
    
//        A[2] = 4
    
//        A[3] = 4

//        A[4] = 4
    
//        A[5] = 2
//    the function should return 2, as explained above.


//    Write an efficient algorithm for the following assumptions:
//    N is an integer within the range[1..100, 000];
//    each element of array A is an integer within the range[−1, 000, 000, 000..1, 000, 000, 000].


    public class EquiLeader
    {
        //tests
        int[] A = [4, 3, 4, 4, 4, 2]; 

        public int Solve(int[] A)
        {
            int totLeaders = 0;
            int index = 0;
            int n = A.Length;

            if (n <= 1)
                return -1;


            int leader1 = A[0];

            int leader2 = A[1];

            while ( index < n-1 )
            {
                var sliceArray1 = A.Take(index +1).OrderBy( x => x).ToArray();  

                leader1 = FindLeader(sliceArray1);
                if(leader1 == -1)
                {
                    index++;
                    continue;
                }
             
                var sliceArray2 = A.Skip(index +1).OrderBy(x => x).ToArray();
                
                leader2 = FindLeader(sliceArray2);
                if (leader2 == -1)
                {
                    index++;
                    continue;
                }

                if (leader1 == leader2)
                    totLeaders++;

                index++;
            }

            if (totLeaders == 0)
                return -1;

            return totLeaders;
        }

        private int FindLeader(int[] slice)
        {
            int count = 0;
            int countLeader = 0;

            if (slice.Length == 1)
                return slice[0];

            if (slice.Length == 2 && slice[0] == slice[1])
                return slice[0];

            if(slice.Length == 2 && slice[0] != slice[1])
                return -1;

            int leader = slice[0];

            for (int i = 0; i < slice.Length -1; i++)
            {

                if (slice[i] == slice[i + 1])
                {
                    count++;

                    //last i
                    if (i == slice.Length - 2)
                    {
                        count++;
                        if (count > countLeader)
                        {
                            countLeader = count;
                            leader = slice[i];
                        }
                    }
                }

                else if (slice[i] != slice[i + 1] && count != 0)
                {
                    count++;
                    if(countLeader > count)
                        countLeader = count;
                    count = 0;
                }

                else
                {
                    if (count > countLeader)
                    {
                        leader = slice[i];
                        countLeader = count;
                        count = 0;
                    }
                }
            }

            int n = (slice.Length +1)/ 2;

            if(countLeader < n)
                return -1;

            return leader;  


        }
    }
}
