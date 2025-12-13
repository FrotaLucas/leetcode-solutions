using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.BeeCrowd
{
    public class StringManipulation
    {
        string str1 = "abcdef";
        string str2 = "cdofhij";

        public void Solve(string str1, string str2)
        {

            //verify if string is within the other
            var t1 = "ABC".Contains("AB"); //true
            var t2 = "ABC".Contains("ab"); //false

            //compare the whole string
            var t3 = "ABC".Equals("ABC"); //true
            var t4 = "ABC".Equals("abc"); //false


            //lexicographic comparisson
            var t5 = "a".CompareTo("A"); // -1 because A is bigger than a
            var t6 = "A".CompareTo("a"); // 1 because A is bigger than a
            var t7 = "b".CompareTo("a"); // 1 because b is bigger than a
            var t8 = "abc".CompareTo("d"); // -1 because d is bigger than a
        }

    }
}
