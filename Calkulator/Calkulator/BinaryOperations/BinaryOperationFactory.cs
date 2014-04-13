using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Calkulator.BinaryOperations
{
    public static class BinaryOperationFactory
    {
        public static IBinaryOperation CreateBinaryOperation(string operationName)
        {
            switch (operationName)
            {
                case "+":
                    return new Addition();
                case"-":
                    return  new Substraction();
                case"*":
                    return new Multiplication();
                case"/":
                    return new Division();
                case "^":
                    return new Involution();
                case "√":
                    return new SquareRoot();
                case "log (e)":
                    return new NaturalLogarithm();
                case "log (s)":
                    return new Logarithm();
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
