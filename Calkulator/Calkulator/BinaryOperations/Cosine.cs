using System;

namespace Calkulator.BinaryOperations
{
    public class Cosine : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Cos(first);
            return result.ToString();
        }
    }
}