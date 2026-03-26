using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.PreFixedSumAndDictionary
{
    public class CountFreqDictionary
    {
        public Dictionary<int, int> Solve(int[] array)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>(); 

            foreach (int i in array)
            {
                if (!dictionary.ContainsKey(i))
                    dictionary[i] = 1;

                dictionary[i]++;    
            }

            Console.WriteLine(dictionary);

            return dictionary;
        }
    }
}
