using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.AdventOfCode
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


        public CountOfFrequency()
        {
            
        }
    }
}
