using System;

namespace Calkulator.BinaryOperations
{
    public class Cotangent : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Pow(Math.Tan(first), (-1.0));
            return result.ToString();
        }
    }
}