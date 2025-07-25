namespace LeetCodeSolutions.Problems.Operations
{
    public class Addition : Operation
    {
        public Addition()
        {
            TypeOperation = "+";
        }

        public override void DoOperation()
        {

            int sum = int.Parse(Numerator1) + int.Parse(Numerator2);

            Console.WriteLine("sum:" + sum);
        }
    }
}
