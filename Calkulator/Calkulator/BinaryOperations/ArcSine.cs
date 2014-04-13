using System;

namespace Calkulator.BinaryOperations
{
    public class ArcSine : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Asin(first);
            return result.ToString();
        }
    }
}