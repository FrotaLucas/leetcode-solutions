using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Dictionaries
{
    //toDo
    //write  algothym that group all words which are anagrams
    //in a awway of string

    //example:
    //string[] list = ["eat", "tea", "tan", "ate", "nat", "bat"];


    //result
    //["eat", "tea", "ate"]
    //["tan", "nat"]
    //["bat"]


    //Hint: STORE ANAGRAMS IN  DICTIONARY
    public class GroupAnagrams
    {
        //string[] list = ["eat", "tea", "tan", "ate", "nat", "bat"];


        public List<string[]> FindAllAnagrams(string[] list)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            foreach(var s in list)
            {
                var key = FindKey(s, list);
                
                if (dictionary.ContainsKey(key))
                    dictionary[key].Add(s);
                else
                {
                    dictionary[key] = new List<string>();
                    dictionary[key].Add(s);
                }
            }

            return dictionary.Values.Select(value => value.ToArray()).ToList();
        }

        private string FindKey(string word, string[] list)
        {
            foreach(var item in list)
            {
                var isKey = CheckAnagram(item, word);

                if (isKey)
                    return item;
            }

            return string.Empty;
        }

        private bool CheckAnagram(string word1, string word2)
        {
            if(word1.Length != word2.Length)
                return false;  
            
            var sequence1 = word1.ToCharArray();
            var sequence2 = word2.ToCharArray();    

            Array.Sort(sequence1);
            Array.Sort(sequence2);

            return sequence1.SequenceEqual(sequence2);
        }
    }
}
