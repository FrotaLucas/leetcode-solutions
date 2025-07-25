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
}
