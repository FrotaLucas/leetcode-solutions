using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Operations
{
    public class OperationFactory
    {
        public static List<Operation> Create()
        {
            return new List<Operation>()
            {

                new Addition()
            };
    }
}
