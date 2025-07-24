using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems
{

    //BEE 1022
    public class TdaRational
    {
        public string Inputs = "4; 1 / 2 + 3 / 4; 2 / 3 * 4 / 5; 6 / 8 - 1 / 4; 5 / 6 / 7 / 8";


        public TdaRational() //depois tentar passar parametro pelo CTOR
        {
            
        }


        public void PrintResult()
        {
            string[] parts = Inputs.Split(";");

            int n = int.Parse(parts[0]);
            string[] equation = new string[n];

            for (int i = 1; i <= n; i++)
            {
                equation[i - 1] = parts[i];
                Console.WriteLine(equation[i-1]);
            }

            foreach (string part in equation) {


                //part[7] 7. elemento sempre eh a operacao
                var result = Operation(part[7].ToString(), part[1].ToString(), part[5].ToString(), part[9].ToString(), part[13].ToString());

                    Console.WriteLine(result);
            
            }

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
                result = numerator.ToString() + "/" + mmc.ToString();

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

                result = numerator.ToString() + "/" + denominator.ToString();

            }

            if (@operator == "/") { 
                int numerator = int.Parse(numerator1)*int.Parse(denominator2);
                int denominator = int.Parse(denominator1)*int.Parse(numerator2);

                result = numerator.ToString() + "/" + denominator.ToString();
            }

            return result;

        }

    }
}
