using System;

namespace Calkulator.BinaryOperations
{
    public class ArcSine : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            double result = Math.Asin(first);
            return result;
        }
    }
}