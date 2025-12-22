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
        int[] D = [2, 2, 1, 3, 3];  //false because 3 does not occur more oft than the marjorit
        int[] E = [1, 2, 3, 4, 5];
        int[] F = [-1, -1, -1, -1, -1];
        int[] G = [-1, -1, -1, 2, 2];
        int[] H = [-1, -1, -1, 2, 2, 2, 2, 2];


        //solution O(n * log n)
        public int Solve(int[] A)
        {
            int result = -1;

            //log n
            Array.Sort(A);


            int i = 0;
            int count = 0;
            int countDominator = 0;
            int minDominator = (A.Length + 1)/ 2;
            int num = -1;

            //n
            while (i < A.Length)
            {
                if (i == A.Length - 1 && count > 0)
                {
                    count++;

                    if (count > countDominator)
                    {
                        countDominator = count;
                        num = A[i];
                    }

                    count = 0;
                }

                if (i < A.Length - 1 && count > 0 && A[i] != A[i + 1])
                {
                    count++;

                    if (count > countDominator)
                    {
                        countDominator = count;
                        num = A[i];
                    }

                    count = 0;
                }


                if (i < A.Length - 1 && A[i] == A[i + 1])
                {
                    count++;
                }


                i++;
            }

            if (countDominator >= minDominator)
                result = num;

            return result;
        }


        //solution O(n * log n) chatGPT
        public int Solve2(int[] A)
        {
            if (A.Length == 0)
                return -1; // ou lance exceção, se preferir

            // O(n log n)
            Array.Sort(A);

            int i = 1;
            int currentCount = 1;
            int maxCount = 1;
            int result = A[0];

            // O(n)
            while (i < A.Length)
            {
                if (A[i] == A[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    result = A[i];
                }

                i++;
            }

            return result;
        }



        //solution O(n^ 2)
        public int Solve3(int[] A)
        {
            int result = -1;
            int minDominator = (A.Length + 1) / 2;
            int dominator = 0;
            int countDominator = 0;
            int count = 0;

            for(int i=0; i < A.Length; i++)
            {

                for(int j=0; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                        count++;
                }

                if(count > countDominator)
                {
                    countDominator = count;
                    count = 0;
                    dominator = A[i];
                }

            }

            if (countDominator > minDominator)
                result = dominator;

            return result;
        }



        //solution O (n)
        public int Solve4(int[] A)
        {
            int dominator = 0;



            return dominator;
        }
    }
}
