using System;

namespace Calkulator.SingleOperations
{
    public class NaturalLogarithm : ISingleOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Log(first, Math.E);
            return result;
        }
    }
}