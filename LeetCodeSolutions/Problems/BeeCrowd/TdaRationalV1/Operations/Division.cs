namespace LeetCodeSolutions.Problems.BeeCrowd.TdaRationalV1.Operations
{
    public class Division : Operation
    {
        public Division() {

            TypeOperation = "/";
        }


        public override void DoOperation()
        {
            int numerator = int.Parse(Numerator1) * int.Parse(Denominator2);
            int denominator = int.Parse(Denominator1) * int.Parse(Numerator2);


            Console.WriteLine($"Division: {numerator}/{denominator}");
        }
    }
}
