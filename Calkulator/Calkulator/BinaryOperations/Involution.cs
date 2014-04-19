using System;

namespace Calkulator.BinaryOperations
{
    public class Involution : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result = Math.Pow(first, second);
            return result;
        }
    }
}
