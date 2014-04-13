using System;

namespace Calkulator.BinaryOperations
{
    public class ArcTangent : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Atan(first);
            return result.ToString();
        }
    }
}