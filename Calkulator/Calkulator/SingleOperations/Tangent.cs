using System;

namespace Calkulator.SingleOperations
{
    public class Tangent : ISingleOperation
    {
        public double Calculate(double first)
        {
            first = first * Math.PI / 180;
            double result = Math.Tan(first);
            return result;
        }
    }
}