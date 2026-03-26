using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSolutions.Dictionaries
{
    public class SubArrayWithGivenSum
    {
        //############VERY HARD

        //🟡 Exercícios Médios(2)
        //4. Subarrays com soma igual a K

        //Dado um array nums e um inteiro k, conte quantos subarrays têm soma exatamente igual a k.

        //Exemplo:

        //nums = [1, 1, 1], k = 2
        //Resposta: 2.

        //OBS: NAO VALE PEGAR ELEMENTOS DO ARRAY SEPARADOS. TEM QUE SER ARRAY CONTIGUO

        //💡 Dica importante:
        //Use:

        //Prefix sum
        //Dictionary para armazenar quantas vezes uma soma apareceu

        //👉 Ideia:

        //se prefix_sum - k já apareceu → existe subarray válido


        //int[] nums = [2, 1, 1, 2]; int k =3;
        //resposta
        //2 arrays
        // [2,1] E [2,1] E [1,2] E [1,2]

        public int Solve(int[] nums, int k)
        {
            // Dicionário para armazenar prefix sums e suas frequências
            Dictionary<int, int> prefixSums = new Dictionary<int, int>();
            prefixSums[0] = 1; // para subarrays que começam do índice 0

            int count = 0;
            int prefixSum = 0;

            foreach (int num in nums)
            {
                prefixSum += num;

                // Verifica se existe algum prefix_sum antigo que forme um subarray somando k
                int target = prefixSum - k;
                if (prefixSums.ContainsKey(target))
                {
                    count += prefixSums[target];
                }

                // Atualiza o dicionário com o prefix_sum atual
                if (!prefixSums.ContainsKey(prefixSum))
                {
                    prefixSums[prefixSum] = 0;
                }
                prefixSums[prefixSum]++;
            }


            return count;
        }
    }
}
