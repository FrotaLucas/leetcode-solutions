using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
namespace LeetCodeSolutions.BeeCrowd
{

    /// <summary>
    /// 
    /// Find the longest common substring between the two informed Strings. The substring can be any
    /// part of the String, including the entire String. If there is no common substring, return 0. The search is case sensitive ('x' != 'X').

    ///Input
    //The input contains several test cases.Each test case is composed by two lines that contains a 
    //  string each.Both input Strings will contain between 1 and 50, inclusive, letters (a-z, A-Z), and/or spaces.
    /// </summary>
    /// 
    public class FindLongestCommonSubtringTask
    {
        //tests
        string str1 = "abcdef";
        string str2 = "cdofhij";

        public int Solve(string str1, string str2)
        {
            int tot = 0;


            //if str1 < str2
            for(int i = 0; i < str1.Length; i++)
            {
                for(int j = 0; j < str2.Length; j++)
                {
                    if(str1[i] == str2[j])
                    {
                        int k1 = i;
                        int k2 = j;
                        while (str1[k1] == str2[k2])
                        {
                            tot++;
                            k1++;
                            k2++;
                        }
                        //for( int k = i; k< str1.Length; k++ )
                        //{
                        //    if()
                        //}
                    }
                }

            }



            return tot;
        }

    }
}
