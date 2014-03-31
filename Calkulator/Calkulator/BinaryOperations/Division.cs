namespace Calkulator.BinaryOperations
{
    class Division:IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = first / second;
            return result.ToString();
        }
    }
}
