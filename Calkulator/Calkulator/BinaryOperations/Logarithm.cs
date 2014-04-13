using System;

namespace Calkulator.BinaryOperations
{
    public class Logarithm : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Log(first, second);
            return result.ToString();
        }
    }
}