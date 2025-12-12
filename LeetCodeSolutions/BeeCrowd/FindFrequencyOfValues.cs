using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeSolutions.BeeCrowd
{
    //function should find all repeated values and return a dictionary
    public class FindFrequencyOfValues
    {
        //paramether
        string str = "1355521";
    

        public Dictionary<string, int> Solve(string str)
        {
            //similar to HashMap no Java
            var dictionary1 = new Dictionary<string, int>();

            var list = str.Select( elem => elem.ToString()).ToList();

            Console.WriteLine(list);

            //sol 2
            foreach (var item in list)
            {
                if (dictionary1.ContainsKey(item))
                    dictionary1[item]++;
                else
                    dictionary1[item] = 1;

            }


            //sol 2
            var dictionary2 = new Dictionary<string, int>();
            dictionary2 = str.Select(elem => elem.ToString()).ToList().GroupBy(elem => elem).ToDictionary(group => group.Key, group => group.Count());

            return dictionary1;
        }
    }
}
