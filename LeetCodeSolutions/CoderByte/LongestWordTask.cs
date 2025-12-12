using System.Text.RegularExpressions;

namespace LeetCodeSolutions.CoderByte
{
    public class LongestWordTask
    {
        //tests

        //string sen = "time## flows here";

        public string Solve(string sen)
        {
            string[] array = sen.Split(' ');
            string longestWord = string.Empty;

            foreach (string word in array)
            {
                var cleanWord = Regex.Replace(word, "[^a-zA-Z]", "");

                if (cleanWord.Length > longestWord.Length)
                    longestWord = cleanWord;
            }

            return longestWord;
        }
    }
}
