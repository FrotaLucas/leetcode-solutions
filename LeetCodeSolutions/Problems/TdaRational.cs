using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions.Problems.Operations;

namespace LeetCodeSolutions.Problems
{

    //BEE 1022
    public class TdaRational
    {
        public string Inputs = "4; 1 / 2 + 3 / 4; 2 / 3 * 4 / 5; 6 / 8 - 1 / 4; 5 / 6 / 7 / 8";
        List<Operation> operations = OperationFactory.Create();


        public TdaRational() //depois tentar passar parametro pelo CTOR
        {
            
        }


        public void PrintResult()
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
                Console.WriteLine(equation[i-1]);
            }

            //foreach (string part in equation) {


            //    //part[7] 7. elemento sempre eh a operacao
            //    var result = Operation(part[7].ToString(), part[1].ToString(), part[5].ToString(), part[9].ToString(), part[13].ToString());

            //        Console.WriteLine(result);
            
            //}


            foreach (string part in equation)
            {
                var operation = Run(part[7].ToString(), part[1].ToString(), part[5].ToString());
                operation.DoOperation();

            }
           
        }

        private Operation Run(string typeOperation, string numerator1, string numerator2)
        {
            if (operations.Any(op => op.TypeOperation == typeOperation) == false)
            {
                throw new Exception("Operation not found");
            }


            //Operation operation = operations.FirstOrDefault(op => op.TypeOperation.Equals(typeOperation));
            Operation operation = operations.Single(op => op.TypeOperation == typeOperation);

            operation.Numerator1 = numerator1;
            operation.Numerator2 = numerator2;

            return operation;
        }

        public string Operation(string @operator, string numerator1, string denominator1, string numerator2, string denominator2)
        {

            string result = "default";

            if(@operator == "+")
            {
                var n1 = int.Parse(numerator1);
                var n2 = int.Parse(numerator2);

                var d1 = int.Parse(denominator1);
                var d2 = int.Parse(denominator2);

                //encontrar MDC
                int a = d1; int b = d2; 
                while ( b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                int mdc = a;

                int mmc = d1*d2/mdc;

                int numerator = n1 * (mmc/ d1) + n2 * (mmc / d2);
                result = $"{numerator}/{mmc}";

            }

            if (@operator == "-") { 
            
                var n1 = int.Parse(numerator1);
                var n2 = int.Parse (numerator2);
                var d1 = int.Parse(denominator1);
                var d2 = int.Parse(denominator2);

                int a = d1; int b = d2;
                while (b != 0) {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                int mdc = a;

                int mmc = d1*d2/mdc;

                int numerator = n1*(mmc/d1) - n2*(mmc/d2);
                result = $"{numerator}/{mmc}";
            }


            if (@operator == "*"){

                int numerator = int.Parse(numerator1) * int.Parse(numerator2);
                var denominator = int.Parse(denominator1)*int.Parse(denominator2);

                result = $"{numerator}/{denominator}";

            }

            if (@operator == "/") { 
                int numerator = int.Parse(numerator1)*int.Parse(denominator2);
                int denominator = int.Parse(denominator1)*int.Parse(numerator2);

                result = $"{numerator}/{denominator}";
            }

            return result;

        }

    }
}
