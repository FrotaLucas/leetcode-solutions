using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Codibility
{
    //print a christimas tree with given height 
    public class MarryChristimasTree
    {
        public void Solve(int height)
        {
            //string baseWidth = string.Empty;

            string tree = string.Empty;

            //for(int b = 0; b < 2*height; b++)
            //{
            //    baseWidth = baseWidth + "*";
            //}

            
            int baseWidth = 2*height;
            int dots = 0;

            for (int i = 0; i < height; i++)
            {
                var width = string.Empty;

                for(int j = baseWidth -1; j >=0; j--)
                {
                    width = width + " ";
                }

                dots = 2*height - baseWidth;
                for(int p=0; p <= dots; p++)
                {
                    width = width + "*";
                }

                baseWidth--;

                var layer = width + "\n";
                tree = tree + layer;
            }

            Console.WriteLine(tree);
        }
    }
}
