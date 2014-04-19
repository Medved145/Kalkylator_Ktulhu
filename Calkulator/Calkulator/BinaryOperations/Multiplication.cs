namespace Calkulator.BinaryOperations
{
    class Multiplication:IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result = first * second;
            return result;
        }
    }
}
