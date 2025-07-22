using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems
{

    public class TdaRational
    {
        public string Inputs = "4; 1 / 2 + 3 / 4; 2 / 3 * 4 / 5; 6 / 8 - 1 / 4;  5 / 6 / 7 / 8";


        public TdaRational() //depois tentar passar parametro pelo CTOR
        {
            
        }


        public void PrintResult()
        {
            string[] parts = Inputs.Split(";");

            int n = int.Parse(parts[0]);


            foreach (string part in parts) {

                double result;

                //part[7] 7. elemento sempre eh a operacao
                switch (part[7])
                {

                    case '*':
                        result = part[1] * part[9] / part[2]* part[3];
                        break;


                }
            
            
            }

        }

        public string Operation(string @operator, string numerator1, string denominator1, string numerator2, string denominator2)
        {

            string result;

            if (@operator == "*"){

                var mmc = int.Parse(denominator1)*int.Parse(denominator2);
                
                int numerator = int.Parse(numerator1) + int.Parse(numerator2);

                result = numerator.ToString() + "/" + mmc.ToString();

            }

            return result;

        }

    }
}
