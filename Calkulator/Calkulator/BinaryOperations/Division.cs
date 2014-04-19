namespace Calkulator.BinaryOperations
{
    class Division:IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result = first / second;
            return result;
        }
    }
}
