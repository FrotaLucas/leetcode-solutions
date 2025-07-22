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


        public void printTdaRational()
        {
            string[] parts = Inputs.Split(";");

            int n = int.Parse(parts[0]);


            foreach (string part in parts) {


                //part[7] 7. elemento sempre eh a operacao
                switch (part[7]) { 
                 
                }
            
            
            }


          
        }

    }
}
