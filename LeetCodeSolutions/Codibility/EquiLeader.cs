using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSolutions.Codibility
{
//    A non-empty array A consisting of N integers is given.

//    The leader of this array is the value that occurs in more than half of the elements of A.


//    An equi leader is an index S such that 0 ≤ S<N − 1 and two sequences A[0], A[1], ..., A[S] and A[S + 1], A[S + 2], ..., A[N − 1] have leaders of the same value.

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
            int index = 1;
            int n = A.Length;

            if (n <= 3)
                return -1;


            int leader1 = A[0];
            int leader2 = A[1];

            int countLeader1 = 0;
            int countLeader2 = 0;

            int count1 = 0;
            int count2 = 0;

            while ( index < n-2 )
            {
                var sliceArray1 = A.Take(index +1).OrderBy( x => x).ToArray();  

                for(int i = 0; i < index; i++)
                {

                    if (sliceArray1[i] == sliceArray1[i+1])
                    {
                        count1++;

                        if( i == index-1)
                        {
                            count1++;

                            if (count1 > countLeader1)
                            {
                                countLeader1 = count1;
                                leader2 = sliceArray1[i];
                            }
                        }
                    }

                    else if (sliceArray1[i] != sliceArray1[i+1] && count1 !=0 )
                    {
                        count1++;
                        countLeader1 = count1;
                        count1 = 0;
                    }

                    else
                    {
                        if(count1 > countLeader1)
                        {
                            leader1 = sliceArray1[i];
                            countLeader1 = count1;
                            count1 = 0;
                        }
                    }
                }
                count1 = 0;

                var slice1 = (index + 2)/ 2;
                if(countLeader1 < slice1)
                {
                    index++;
                    continue;
                }

                for(int j = 0; j < n - index - 2; j++)
                {
                    var sliceArray2 = A.Skip(index +1).OrderBy(x => x).ToArray();

                    if (sliceArray2[j] == sliceArray2[j + 1])
                    {
                        count2++;

                        if( j == index-1)
                        {
                            count2++;
                            if(count2 > countLeader2)
                            {
                                countLeader2 = count2;
                                leader2 = sliceArray2[j];
                            }
                        }
                    }

                    else if (sliceArray2[j] != sliceArray2[j+1] && count2 !=0 )
                    {
                        count2++;
                        countLeader2 = count2;
                        count2 = 0;
                    }

                    else
                    {
                        if(count2 > countLeader2)
                        {
                            leader2 = sliceArray2[j];
                            countLeader2 = count2;
                            count2 = 0;
                        }
                    }
                }
                count2 = 0;

                var slice2 = (n - index + 2)/2;
                if(countLeader2 < slice2)
                {
                    index++;
                    continue;
                }

                if(leader1 == leader2)
                    totLeaders++;

                index++;
            }

            if (totLeaders == 0)
                return -1;

            return totLeaders;
        }
    }
}
