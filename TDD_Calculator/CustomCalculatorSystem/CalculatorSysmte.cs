using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Calculator.CustomCalculatorSystem
{
    public class CalculatorSystem
    {
        int num1, num2, result;
        string operatorName = "";
        public CalculatorSystem()
        {
            operatorName = "";
        }
        internal object Add(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
            result = number1 + number2;
            return result;
        }


        public override string ToString()
        {
            return $"({num1}{operatorName}{num2})={result}";
        }

        internal object Sub(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
            result = number1 - number2;
            operatorName = "-";
            return result;
        }
    }
}
