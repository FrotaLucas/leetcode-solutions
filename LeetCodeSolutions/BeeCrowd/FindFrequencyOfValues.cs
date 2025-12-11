using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeSolutions.BeeCrowd
{
    public class FindFrequencyOfValues
    {
        public Dictionary<string, int> Solve(string str)
        {
            //similar to HashMap
            var dictionary = new Dictionary<string, int>();

            var list = str.Select( elem => elem.ToString()).ToList();

            Console.WriteLine(list);


            //foreach (var item in list)
            //{
            //    dictionary[item]++;
            //}


            //sol 2
            var dictionary2 = new Dictionary<string, int>();
            dictionary2 = str.Select(elem => elem.ToString()).ToList().GroupBy(elem => elem).ToDictionary(group => group.Key, group => group.Count());

            return dictionary;
        }
    }
}
