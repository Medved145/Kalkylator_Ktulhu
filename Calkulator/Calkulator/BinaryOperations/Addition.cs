namespace Calkulator.BinaryOperations
{
    public class Addition:IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = first + second;
            return result.ToString();
        }
    }
}
