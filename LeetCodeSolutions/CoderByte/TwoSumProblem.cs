using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.CoderByte
{
    /// <summary>
    /// 
    /// The two sum problem is a common interview question, and it is a variation of the subset
    /// sum problem. There is a popular dynamic programming solution for the subset sum problem,
    /// but for the two sum problem we can actually write an algorithm that runs in O(n) time. 
    /// The challenge is to find all the pairs of two integers in an unsorted array that sum up to a given S. 
    
    
    ///For example, if the array is [3, 5, 2, -4, 8, 11] and the sum is 7, 
    /// your program should return [[11, -4], [2, 5]] because 11 + -4 = 7 and 2 + 5 = 7.
    /// 
    /// 
    /// </summary>
    public class TwoSumProblem
    {


        //1 better performance
        public List<int[]> Solve(int[]A, int x)
        {
            List<int[]> peers = new List<int[]>();


            return peers;
        }

        
        //2 lower performance O(n^2)
        public List<int[]> SolveV3(int[] A, int x)
        {
            //int[] peers = default!;
            var peers = new List<int[]>();
            int n = A.Length;


            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] + A[j] == x)
                    {
                        //op1
                        //var peer = new int[] { A[i], A[j] };

                        //op2
                        var peer = new int[2];
                        peer[0] = A[i];
                        peer[1] = A[j];

                        peers.Add(peer);
                    }
                }
            }

            peers.ForEach(elem => elem.ToList().ForEach(array => Console.WriteLine(array)));

            return peers;
        }

        public List<int[]> SolveV2(int[] A, int x)
        {
            var keys = new HashSet<string>();
            List<int[]> peers = new List<int[]>();
            int n = A.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i] + A[j] == x)
                    {
                        string key = A[i] > A[j] ? $"{A[i]}{A[j]}" : $"{A[j]}{A[i]}";

                        if (keys.Add(key))
                        {
                            var peer = new int[] { A[i], A[j] };
                            peers.Add(peer);
                        }
                    }
                }
            }


            peers.ForEach(elem => elem.ToList().ForEach(array => Console.WriteLine(array)));

            return peers;
        }
    }
}
