using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Dictionaries
{

    // 2. Soma de intervalo(Prefix Sum básico)

    //Dado um array de int, responda várias queries do tipo:

    //qual a soma do índice L até R?

    //Exemplo:

    //nums = [2, 4, 6, 8, 10]
    //queries = [(1, 3), (0, 2)]
    //Resposta: [18, 12]

    //💡 Dica: Pré-calcule um array de prefix sum.
    public class IntervalSum
    {

        public int Solve(int[] array, int l, int k)
        {
            int n = array.Length;

            if (l > k || (k > n - 1))
                return 0;

            if(n == 2)
                return array.Sum();

            int[] prefixedSum = new int[n];
            prefixedSum[0] = array[0];


            for(int i = 1; i < n; i++)
            {
                prefixedSum[i] = prefixedSum[i - 1] + array[i];
            }


            return prefixedSum[k] - prefixedSum[l-1];
        }

    }
}
