using System;

namespace Calkulator.SingleOperations
{
    public class ArcSine : ISingleOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Asin(first);
            result = result * 180 / Math.PI;
            return result;
        }
    }
}