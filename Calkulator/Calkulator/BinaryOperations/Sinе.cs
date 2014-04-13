using System;

namespace Calkulator.BinaryOperations
{
    public class Sine : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Sin(first);
            return result.ToString();
        }
    }
}
