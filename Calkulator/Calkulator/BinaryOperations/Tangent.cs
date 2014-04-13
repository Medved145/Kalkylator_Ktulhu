using System;

namespace Calkulator.BinaryOperations
{
    public class Tangent : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Tan(first);
            return result.ToString();
        }
    }
}