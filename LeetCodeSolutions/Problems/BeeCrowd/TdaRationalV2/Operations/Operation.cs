using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.BeeCrowd.TdaRationalV2.Operations
{
    public abstract class Operation
    {
        public string TypeOperation {  get; set; }
        public Operation()
        {
            
        }

        public abstract void DoOperation();
    }
}
