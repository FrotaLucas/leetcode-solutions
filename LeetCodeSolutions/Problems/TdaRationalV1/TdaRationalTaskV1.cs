using LeetCodeSolutions.Problems.TdaRationalV1.Operations;

namespace LeetCodeSolutions.Problems.TdaRationalV1
{

    //BEE 1022

    /// <summary>
    /// You were invited to do a little job for your Mathematic teacher. The job is to read a Mathematic expression in format of two rational 
    /// numbers (numerator / denominator) and present the result of the operation. Each operand or operator is separated by a blank space.
    /// The input sequence (each line) must respect the following format: number, (‘/’ char), number, 
    /// operation char (‘/’, ‘*’, ‘+’, ‘-‘), number, (‘/’ char), number. The answer must be presented followed by ‘=’ operator and 
    /// the simplified answer. If the answer can’t be simplified, it must be repeated after a ‘=’ operator.

    // Considering N1 and D1 as numerator and denominator of the first fraction, follow the orientation about how to do each one of these 4 operations:

    //Sum: (N1* D2 + N2* D1) / (D1* D2)
    //Subtraction: (N1* D2 - N2* D1) / (D1* D2)
    //Multiplication: (N1* N2) / (D1* D2)
    // Division: (N1/D1) / (N2/D2), that means(N1* D2)/(N2* D1)
    //Input
    //The input contains several cases of test.The first value is an integer N(1 ≤ N ≤ 1*104), indicating the amount of cases of test that must be read.Each case of test contains a rational value X(1 ≤ X ≤ 1000), an operation(-, +, * or /) and another rational value Y(1 ≤ Y ≤ 1000).

    //Output
    //The output must be a rational number, followed by a “=“ sign and another rational number, that is the simplification
    //of the first value.In case of the first value can’t be simplified, the same value must be repeated after the ‘=’ sign.
    /// </summary>
    public class TdaRationalTaskV1
    {
        public string Inputs = "4; 1 / 2 + 3 / 4; 2 / 3 * 4 / 5; 6 / 8 - 1 / 4; 5 / 6 / 7 / 8";
        List<Operation> operations = OperationFactory.Create();
        public TdaRationalTaskV1() //depois tentar passar parametro pelo CTOR
        {
        }

        public void Solve()
        {

            //Liskov priciple 
            //var calculation1 = new Calculation(string numerator1, string denominator1, string numerator2, string denominator2);
            // calculation1.Operation = new Addition();

            //var calculation2 = new Calculation(string numerator1, string denominator1, string numerator2, string denominator2);
            // calculation2.Operation = new Subtraction();




            string[] parts = Inputs.Split(";");

            int n = int.Parse(parts[0]);
            string[] equation = new string[n];

            for (int i = 1; i <= n; i++)
            {
                equation[i - 1] = parts[i];
                Console.WriteLine(equation[i - 1]);
            }

            //foreach (string part in equation) {


            //    //part[7] 7. elemento sempre eh a operacao
            //    var result = Operation(part[7].ToString(), part[1].ToString(), part[5].ToString(), part[9].ToString(), part[13].ToString());

            //        Console.WriteLine(result);

            //}


            foreach (string part in equation)
            {
                var operation = Run(part[7].ToString(), part[1].ToString(), part[5].ToString(), part[9].ToString(), part[13].ToString());
                operation.DoOperation();

            }

        }

        private Operation Run(string typeOperation, string numerator1, string denominator1, string numerator2, string denominator2)
        {
            if (operations.Any(op => op.TypeOperation == typeOperation) == false)
            {
                throw new Exception("Operation not found");
            }


            //Operation operation = operations.FirstOrDefault(op => op.TypeOperation.Equals(typeOperation));
            Operation operation = operations.Single(op => op.TypeOperation == typeOperation);

            operation.Numerator1 = numerator1;
            operation.Numerator2 = numerator2;
            operation.Denominator1 = denominator1;
            operation.Denominator2 = denominator2;

            return operation;
        }

        public string Operation(string @operator, string numerator1, string denominator1, string numerator2, string denominator2)
        {

            string result = "default";

            if (@operator == "+")
            {
                var n1 = int.Parse(numerator1);
                var n2 = int.Parse(numerator2);

                var d1 = int.Parse(denominator1);
                var d2 = int.Parse(denominator2);

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
                result = $"{numerator}/{mmc}";

            }

            if (@operator == "-")
            {

                var n1 = int.Parse(numerator1);
                var n2 = int.Parse(numerator2);
                var d1 = int.Parse(denominator1);
                var d2 = int.Parse(denominator2);

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
                result = $"{numerator}/{mmc}";
            }


            if (@operator == "*")
            {

                int numerator = int.Parse(numerator1) * int.Parse(numerator2);
                var denominator = int.Parse(denominator1) * int.Parse(denominator2);

                result = $"{numerator}/{denominator}";

            }

            if (@operator == "/")
            {
                int numerator = int.Parse(numerator1) * int.Parse(denominator2);
                int denominator = int.Parse(denominator1) * int.Parse(numerator2);

                result = $"{numerator}/{denominator}";
            }

            return result;

        }

    }


}
