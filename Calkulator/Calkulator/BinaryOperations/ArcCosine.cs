using System;

namespace Calkulator.BinaryOperations
{
    public class ArcCosine : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            double result = Math.Acos(first);
            return result.ToString();
        }
    }
}