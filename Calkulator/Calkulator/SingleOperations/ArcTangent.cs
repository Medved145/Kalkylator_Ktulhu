using System;

namespace Calkulator.SingleOperations
{
    public class ArcTangent : ISingleOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Atan(first);
            result = result * 180 / Math.PI;
            return result;
        }
    }
}