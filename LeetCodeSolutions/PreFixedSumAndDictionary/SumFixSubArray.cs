using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.PreFixedSumAndDictionary
{

    //    Exercícios Fáceis(3)
    //1. Soma de subarray fixa

    //Dado um array de inteiros e um inteiro k, encontre a soma de todos os subarrays de tamanho k.

    //Exemplo:

    //nums = [1, 2, 3, 4, 5], k = 3

    //1+2+3
    //2+3+4
    //3+4+5

    //Resposta: [6, 9, 12]

    //💡 Dica: Use prefix sum para calcular cada janela em O(1).

    public class SumFixSubArray
    {

        public List<int> Solve(int[] array, int k)
        {
            //prefix sum
            int[] prefixedSum = new int[array.Length];

            prefixedSum[0] = array[0];


            //error
            if (array.Length < k)
                return new List<int>();

            for(var i=1; i< array.Length; i++)
            {
                prefixedSum[i] = prefixedSum[i-1] + array[i];
            }

            //how many subarrays ?
            //key dictionary 1. sub, 2. sub
            //value dictionary prefixedSum[]

            
            //firt element
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary[$"sum 0 {k-1}"] = prefixedSum[k-1];

            int j = k;
            while(j <= array.Length - 1)
            {

                var sum = prefixedSum[j] - prefixedSum[j -k];
                dictionary.Add($"accumulate {j} - accumulate {j-k}", sum);
                j = j + 1;
            }

            dictionary.Keys.ToList().ForEach(key => Console.WriteLine(key));
            
            return dictionary.Values.ToList();
        }
    }
}
