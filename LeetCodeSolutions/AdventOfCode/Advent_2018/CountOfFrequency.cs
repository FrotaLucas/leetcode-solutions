using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.AdventOfCode.Advent_2018
{
    public class CountOfFrequency
    {

        //Challenge Advent Calender 2018
        //Day 2 advent Calender
        //link
        //https://adventofcode.com/2018/day/2

        //Descripttion

        // Challenge: Advent of Code 2018
        // Day 2 – Inventory Management System
        //
        // Description:
        // Given a list of box ID strings, analyze the frequency of letters in each ID.
        // For each ID:
        // - Check if any letter appears exactly two times.
        // - Check if any letter appears exactly three times.
        // Count how many IDs contain a letter that appears exactly twice (twos)
        // and how many contain a letter that appears exactly three times (threes).
        //
        // The final result (checksum) is obtained by multiplying:
        // checksum = twos * threes
        //
        // Example:
        // Input IDs:
        // abcdef   -> no letters repeated (ignored)
        // bababc   -> 'a' appears twice, 'b' appears three times (counts for both)
        // abbcde   -> 'b' appears twice (counts for twos)
        // abcccd   -> 'c' appears three times (counts for threes)
        // aabcdd   -> 'a' and 'd' appear twice (counts once for twos)
        // abcdee   -> 'e' appears twice (counts for twos)
        // ababab   -> 'a' and 'b' appear three times (counts once for threes)
        //
        // Result:
        // twos = 4
        // threes = 3
        // checksum = 4 * 3 = 12

        string ids_string = "abcdef,bababc,abbcde,abcccd,aabcdd,abcdee,ababab";

        public int Solve(string ids_string)
        {
            string[] ids = ids_string.Split(',');

            int countPairs = 0;
            int counttriples = 0;

            foreach (var id in ids)
            {
                var (pair, triple) = CountTuples(id);

                countPairs += pair;
                counttriples += triple;
            }

            return countPairs * counttriples;
        }


        //tuple
        public (int pairs, int triples) CountTuples(string id_string)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();


            foreach(var element in id_string)
            {
                if(dictionary.ContainsKey(element))
                    dictionary[element]++;
                else
                    dictionary[element] = 1;
            }

            int pairs = dictionary.Values.Any(value => value == 2) ? 1 : 0;   
            int triples = dictionary.Values.Any( value => value == 3 ) ? 1 : 0;

            return (pairs, triples);
        }
    }
}
