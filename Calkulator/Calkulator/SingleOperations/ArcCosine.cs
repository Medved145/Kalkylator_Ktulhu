using System;

namespace Calkulator.SingleOperations
{
    public class ArcCosine : ISingleOperation
    {
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Арксинус не принимает числа >1 и <-1, так же как и арккосинус.");
            }
            double result = Math.Acos(first);
            result = result * 180 / Math.PI;
            return result;
        }
    }
}