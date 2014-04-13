using System;

namespace Calkulator.BinaryOperations
{
    public class NaturalLogarithm : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Log(first, Math.E);
            return result.ToString();
        }
    }
}