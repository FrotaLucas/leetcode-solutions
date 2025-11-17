namespace LeetCodeSolutions.BeeCrowd.TdaRationalV1.Operations
{
    public class Subtraction : Operation
    {

        public Subtraction() {
            TypeOperation = "-";
        }

        public override void DoOperation()
        {
            var n1 = int.Parse(Numerator1);
            var n2 = int.Parse(Numerator2);
            var d1 = int.Parse(Denominator1);
            var d2 = int.Parse(Denominator2);

            int a = d1; int b = d2;
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            int mdc = a;

            int mmc = d1 * d2 / mdc;

            int numerator = n1 * (mmc / d1) - n2 * (mmc / d2);

            Console.WriteLine($"Subtraction: {numerator}/{mmc}");
        }
    }

}
