namespace LeetCodeSolutions.Problems.TdaRationalV1.Operations
{
    public class OperationFactory
    {
        public static List<Operation> Create()
        {
            return new List<Operation>()
            {

                new Addition(),
                new Subtraction(),
                new Multiplication(),
                new Division(),

            };
        }
    }
}
