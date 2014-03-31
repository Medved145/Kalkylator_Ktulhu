namespace Calkulator.BinaryOperations
{
    class Substraction:IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = first - second;
            return result.ToString();
        }
    }
}
