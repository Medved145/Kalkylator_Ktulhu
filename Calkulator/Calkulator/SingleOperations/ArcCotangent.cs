using System;

namespace Calkulator.SingleOperations
{
    public class ArcCotangent : ISingleOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Pow(Math.Atan(first), (-1.0));
            result = result * 180 / Math.PI;
            return result;
        }
    }
}