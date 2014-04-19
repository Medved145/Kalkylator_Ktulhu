using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkulator.SingleOperations
{
    public static class SingleOperationFactory
    {
        public static ISingleOperation CreateSingleOperation(string operationName)
        {
            switch (operationName)
            {
                case "log (e)":
                    return new NaturalLogarithm();
                case "sin":
                    return new Sine();
                case "cos":
                    return new Cosine();
                case "tg":
                    return new Tangent();
                case "ctg":
                    return new Cotangent();
                case "asin":
                    return new ArcSine();
                case "acos":
                    return new ArcCosine();
                case "atg":
                    return new ArcTangent();
                case "actg":
                    return new ArcCotangent();
                default:
                    throw new ArgumentException("Неизвестная операция!", "operationName");
            }
        }
    }
}
