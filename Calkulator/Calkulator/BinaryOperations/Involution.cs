namespace Calkulator.BinaryOperations
{
    public class Involution : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = first * first;
            return result.ToString();
        }
    }
}
