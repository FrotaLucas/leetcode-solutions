namespace LeetCodeSolutions.Problems.Operations
{
    public class Operation
    {
        public string TypeOperation { get; set; } = string.Empty; //+, -, /, *
        public string Numerator1 { get; set; }
        public string Numerator2 { get; set; }

        public Operation()
        {

        }
        public Operation(string typeOperation, string numerator1, string numerator2)
        {
            TypeOperation = typeOperation;
            Numerator1 = numerator1;
            Numerator2 = numerator2;
        }
        public virtual void DoOperation() { }
    }
}
