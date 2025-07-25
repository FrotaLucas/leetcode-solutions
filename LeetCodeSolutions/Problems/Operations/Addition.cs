namespace LeetCodeSolutions.Problems.Operations
{
    public class Addition : Operation
    {
        public Addition() : base("+", "numerator1", "numerator2") { }

        public override void DoOperation()
        {

            int sum = int.Parse(Numerator1 + Numerator2);

            Console.WriteLine("sum:" + sum);
        }
    }
}
