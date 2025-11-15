using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Codibility
{
    // A small frog wants to get to the other side of the road. The frog is currently located at position X
    // and wants to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.

    // Count the minimal number of jumps that the small frog must perform to reach its target.

    // Write a function:

    // function solution(X: number, Y: number, D: number): number;
    // content_copy

    // that, given three integers X, Y and D, returns the minimal number of jumps from position X to
    // a position equal to or greater than Y.

    // For example, given:

    //   X = 10
    //   Y = 85
    //   D = 30

    // content_copy
    // the function should return 3, because the frog will be positioned as follows:

    // after the first jump, at position 10 + 30 = 40
    // after the second jump, at position 10 + 30 + 30 = 70
    // after the third jump, at position 10 + 30 + 30 + 30 = 100
    // Write an efficient algorithm for the following assumptions:
    public class FrogMinJumps
    {
        public int Solve(int x, int y, int d)
        {

            int yf = x;
            int totSteps = 0;

            while(yf <= y)
            {
                yf = yf + d;
                totSteps++;
            }

            return totSteps;
        }
    }
}
