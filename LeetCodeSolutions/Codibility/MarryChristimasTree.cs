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
            Console.WriteLine("Happy Mary Christimas!!!\n");

            string tree = string.Empty;

            int emptyWidth = 2*height;
            int filledWith = 0;

            for (int i = 0; i < height; i++)
            {
                var str = string.Empty;

                for(int j = emptyWidth -1; j >=0; j--)
                {
                    str = str + " ";
                }

                filledWith = 2*height - emptyWidth;
                for(int p=0; p <= 2*filledWith; p++)
                {
                    str = str + "*";
                }

                emptyWidth--;

                var layer = str + "\n";
                tree = tree + layer;
            }
            //Console.WriteLine($"final emptyWidth:{emptyWidth}");
            //Console.WriteLine($"final filledWidth:{2*filledWith}");

            Console.WriteLine(tree);
        }
    }
}
