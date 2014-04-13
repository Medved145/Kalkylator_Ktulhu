using System;

namespace Calkulator.BinaryOperations
{
    public class Involution : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Pow(first, second);
            return result.ToString();
        }
    }
}
