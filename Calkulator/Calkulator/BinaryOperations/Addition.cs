namespace Calkulator.BinaryOperations
{
    public class Addition:IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
