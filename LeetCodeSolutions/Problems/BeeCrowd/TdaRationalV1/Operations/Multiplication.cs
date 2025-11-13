namespace LeetCodeSolutions.Problems.BeeCrowd.TdaRationalV1.Operations
{
    public class Multiplication : Operation
    {

        public Multiplication() {
            TypeOperation = "*";
        }


        public override void DoOperation()
        {
            int numerator = int.Parse(Numerator1) * int.Parse(Numerator2);
            var denominator = int.Parse(Denominator1) * int.Parse(Denominator2);

            Console.WriteLine($"Multiplication: {numerator}/{denominator}");
        }
    }
}
