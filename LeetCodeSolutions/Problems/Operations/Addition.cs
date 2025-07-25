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

            var n1 = int.Parse(Numerator1);
            var n2 = int.Parse(Numerator2);

            var d1 = int.Parse(Denominator1);
            var d2 = int.Parse(Denominator2);

            //encontrar MDC
            int a = d1; int b = d2;
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            int mdc = a;

            int mmc = d1 * d2 / mdc;

            int numerator = n1 * (mmc / d1) + n2 * (mmc / d2);
            //result = $"{numerator}/{mmc}";


            //int sum = int.Parse(Numerator1) + int.Parse(Numerator2);

            Console.WriteLine($"sum: {numerator}/{mmc} ");
        }
    }
}
