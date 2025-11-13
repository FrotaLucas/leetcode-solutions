using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace LeetCodeSolutions.Problems.CoderByte
{



    /// <summary>
    ///Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 
    ///2 elements: the first element will represent a list of comma-separated numbers sorted in ascending order, 
    ///the second element will represent a second list of comma-separated numbers(also sorted). Your goal is 
    ///to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order.
    ///If there is no intersection, return the string false.
    /// </summary>
    

    public class FindIntersectionTask
    {
        public string FindIntersection(string[] strArr)
        {
            var firstString = strArr[0].Split(",");
            var secondString = strArr[1].Split(",");
            string occurance = string.Empty;
            foreach (var s in secondString)
            {
                var foundS = firstString.FirstOrDefault(elem => elem == s);
                if (foundS != null)
                    occurance += $"{foundS},";
            }
            if (occurance.EndsWith(","))
                occurance = occurance.Substring(0, occurance.Length - 1);
            // code goes here  
            return occurance;

        }
    
        public string FindInterSectionV2(string[] strArr)
        {
            var firstString = strArr[0].Split(',')
                .Select(s => s.Trim())
                .ToHashSet();

            var secondString = strArr[1].Split (",").Select(s => s.Trim()).ToList();

            var intersection = secondString.Where(elem => firstString.Contains(elem)).ToList();

            if (intersection.Count == 0)
                return "false";

            //Console.WriteLine(firstString);

            return string.Join(",", intersection);

        }
    }

}
