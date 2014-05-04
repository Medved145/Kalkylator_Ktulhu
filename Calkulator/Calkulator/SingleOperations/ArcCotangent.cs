using System;

namespace Calkulator.SingleOperations
{
    public class ArcCotangent : ISingleOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Atan(first)+(2/3)*Math.Atan(1);
            result = result * 180 / Math.PI;
            return result;
        }
    }
}