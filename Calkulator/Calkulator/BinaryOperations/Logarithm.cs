using System;

namespace Calkulator.BinaryOperations
{
    public class Logarithm : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            if (first < 0 || (second < 0 || second == 1))
            {
                throw new Exception("Логарифм бо-бо");
            }
            double result = Math.Log(first, second);
            return result;
        }
    }
}