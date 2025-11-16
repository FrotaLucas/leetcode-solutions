using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Codibility
{
    //print a christimas tree with given height 
    public class MarryChristimasTree
    {
        public void Solve(int height)
        {
            string width = "*********";
            string tree = "";

            for (int i = 0; i < height; i++)
            {
                var layer = width + "\n";
                tree = tree + layer;
            }

            Console.WriteLine(width);
        }
    }
}
