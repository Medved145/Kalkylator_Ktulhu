using System;

namespace Calkulator.SingleOperations
{
    public class Cotangent : ISingleOperation
    {
        public double Calculate(double first)
        {
            first = first * Math.PI / 180;
            double result = Math.Pow(Math.Tan(first), (-1.0));
            return result;
        }
    }
}