using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Dictionaries
{
    public class WordFreqStream
    {

        //create a method that should find the list of itemns more frequent
        
        //ex:

        //string[] stream = ['apple', 'banana', 'apple', 'orange', 'apple', 'banana'];


        //should return apple, banana
        public string[] FindTopKeys(string[] stream)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string key in stream)
            {
                if (dictionary.ContainsKey(key))
                    dictionary[key]++;
                else
                    dictionary[key] = 1;
            }

            string[] keys = dictionary.Where( peer => peer.Value > 1).Select(peer => peer.Key).ToArray();

            return keys;
        }
    }
}
