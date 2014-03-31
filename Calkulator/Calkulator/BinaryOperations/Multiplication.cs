namespace Calkulator.BinaryOperations
{
    class Multiplication:IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = first * second;
            return result.ToString();
        }
    }
}
