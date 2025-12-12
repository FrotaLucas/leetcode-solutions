namespace LeetCodeSolutions.CoderByte
{
    //    Task

    //Write a function that, given a string (X) containing an array of N semi-colon(;) separated integers, returns a
    //semi-colon separated string of:

    //the number of integers occurring multiple times

    //the lowest duplicate integer(0 if no duplicates)

    //the highest duplicate integer(0 if no duplicates)

    //elements of the input integers without duplicates.The ORDERING of the items must not change.If numbers appear multiple times,
    //the first occurring integer has to be preserved.

    //You solution must have O(n) runtimes. Write the code in C#


    //example
    //"1;3;2;3;4;1;5;3"
    //return

    //2;1;3;1;3;2;4;5
    //Explanation:

    //count numbers duplicated: 1, 3 → count = 2

    //Lowest duplicate = 1

    //Highest duplicate = 3

    //Input without duplicates: 1;3;2;4;5

    public class CountOccurancesAndFrequencyTask
    {
        //tests
        //string str = "1;3;2;3;4;1;5;3";



        public string Solve(string str)
        {
            int[] arrayInteger = str.Split(';').Select(s => int.Parse(s)).ToArray();

            HashSet<int> uniques = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();   

            int min = arrayInteger[0];

            int max = 0;
            foreach (int num in arrayInteger)
            {
                if (uniques.Add(num)) 
                {
                  
                }

                else if (duplicates.Add(num) )
                {
                    if (num > max)
                        max = num;

                    else if (num < min)
                        min = num;
                }



            }

            string result = string.Empty;

            string listInputs = string.Empty;
            foreach (var elem in uniques)
                listInputs += $"{elem};";

            result = $"{duplicates.Count};" + $"{min};{max};" + listInputs;

            //arrayStr.ToList().ForEach( w => Console.Write(w));    
            return result;
        }
    }//2;1;3;1;3;2;4;5
}
