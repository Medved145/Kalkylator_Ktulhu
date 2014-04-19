using System;

namespace Calkulator.BinaryOperations
{
    public class Logarithm : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result = Math.Log(first, second);
            return result;
        }
    }
}