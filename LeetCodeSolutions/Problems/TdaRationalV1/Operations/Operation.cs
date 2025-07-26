namespace LeetCodeSolutions.Problems.TdaRationalV1.Operations
{
    public class Operation
    {
        public string TypeOperation { get; set; } = string.Empty; //+, -, /, *

        public string Numerator1 { get; set; }

        public string Numerator2 { get; set; }

        public string Denominator1 { get; set; }

        public string Denominator2 { get; set; }

        //construtor desse classe Operation que sera chamado ao criar classes filhas
        //sem ele, o construtor logo depois vai ser chamado levando a um erro pq nao tem parametro.
        protected Operation()
        {

        }


        public virtual void DoOperation() { }
    }
}
