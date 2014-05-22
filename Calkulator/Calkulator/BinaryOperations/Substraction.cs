namespace Calkulator.BinaryOperations
{
    class Substraction : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result = first - second;
            return result;
        }
    }
}
