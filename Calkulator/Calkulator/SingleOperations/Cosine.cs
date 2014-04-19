using System;

namespace Calkulator.SingleOperations
{
    public class Cosine : ISingleOperation
    {
        public double Calculate(double first)
        {
            first = first * Math.PI / 180;
            double result = Math.Cos(first);
            return result;
        }
    }
}