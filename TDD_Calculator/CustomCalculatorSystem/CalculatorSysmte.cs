using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Calculator.CustomCalculatorSystem
{
    enum Operatos { Add, Sub, Mul, Div, None }

    internal static class OperatorExtention
    {
        public static string GetOperator(this Operatos value)
        {
            switch (value)
            {
                case Operatos.Add:
                    return "+";
                    break;
                case Operatos.Sub:
                    return "-";
                    break;
                case Operatos.Mul:
                    break;
                case Operatos.Div:
                    break;
                case Operatos.None:
                    break;
                default:
                    break;
            }
            return "-";

        }
    }
    public class CalculatorSystem
    {


        int num1, num2, result;
        Operatos operatorName = Operatos.None;
        public CalculatorSystem()
        {
            num1 = 0;
            num2 = 0;
            result = 0;
            operatorName = Operatos.None;
        }
        internal object Add(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
            result = number1 + number2;
            operatorName = Operatos.Add;
            return result;
        }


        public override string ToString()
        {
            if (operatorName == Operatos.None)
                return "";
            return $"({num1}{operatorName.GetOperator()}{num2})={result}";
        }

        internal object Sub(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
            result = number1 - number2;
            operatorName = Operatos.Sub;
            return result;
        }
    }
}
