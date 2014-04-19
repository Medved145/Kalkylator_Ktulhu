using System;

namespace Calkulator.SingleOperations
{
    public class ArcCosine : ISingleOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Acos(first);
            result = result * 180 / Math.PI;
            return result;
        }
    }
}