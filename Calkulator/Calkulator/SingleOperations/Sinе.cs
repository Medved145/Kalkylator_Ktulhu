using System;

namespace Calkulator.SingleOperations
{
    public class Sine : ISingleOperation
    {
        public double Calculate(double first)
        {
            first = first * Math.PI / 180;
            double result = Math.Sin(first);
            return result;
        }
    }
}
