using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.StringV1
{
    public class FindMissingCharacter
    {
        //find the missing caracther

        public void Solve(string[] list)
        {
            // encontra a menor e a maior palavra
            var small = list.OrderBy(x => x.Length).First();
            var big = list.OrderBy(x => x.Length).Last();

            int i = 0;

            // procura a posição onde começam a diferir
            while (i < small.Length && small[i] == big[i])
            {
                i++;
            }

            // se percorreu tudo, a letra faltante é a última
            if (i == small.Length)
            {
                Console.WriteLine("There is no Missing letter ");
            }
            else
            {
                Console.WriteLine("Missing letter is: " + big[i]);
            }
        }


    }
}
