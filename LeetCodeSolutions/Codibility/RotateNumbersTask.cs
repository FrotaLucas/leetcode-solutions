using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Codibility
{
    // The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.

    // Write a function:
    // function solution(A: number[], K: number): number[];
    // that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.

    // For example, given

    //     A = [3, 8, 9, 7, 6]
    //     K = 3

    // the function should return [9, 7, 6, 3, 8]. Three rotations were made:

    public class RotateNumbersTask
    {
        public int[] Solve(int[]A, int k)
        {
            int n = A.Length;

            //ERRO GRAVE. rotate nao esta recebendo valores de A. Esta recebendo referencia. Logo cada elemento de rotate
            //vai sempre apontar para seu correspondente em A.
            //int[] rotate = A;

            //CORRETO
            int[] rotate = new int[n];

            for(int j=0; j < n; j++)
            {
                var i = j + k;

                if(i< n)
                    rotate[i] = A[j];

                else
                {
                    var rest = n - 1 - j;
                    i = k - rest-1;
                    rotate[i] = A[j];
                }
            }

            rotate.ToList().ForEach( x => Console.WriteLine(x));    

            return rotate;
        }
    }
}
