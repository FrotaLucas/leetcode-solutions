using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSolutions.PreFixedSumAndDictionary
{
    //    3. Contar frequência de números

    //Dado um array nums, retorne um dicionário com a contagem de cada número.

    //Exemplo:

    //nums = [1, 2, 2, 3, 1, 1]
    //Resposta: { 1:3, 2:2, 3:1}

    //💡 Dica: Use Dictionary direto.

    public class CountFreqDictionary
    {
        public Dictionary<int, int> Solve(int[] array)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>(); 

            foreach (int i in array)
            {
                if (!dictionary.ContainsKey(i))
                    dictionary[i] = 1;

                else 
                    dictionary[i]++;
            }

            //print result
            var result = string.Join(',', dictionary.Select(peer => $"{peer.Key}:{peer.Value}") );

            Console.WriteLine(result);

            return dictionary;
        }
    }
}
