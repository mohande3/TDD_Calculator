﻿


namespace TDD_Calculator
{
    internal class Calculator
    {
        public Calculator()
        {
        }

        //public object Add(int number1, int number2)
        //{
        //    return number1 + number2;
        //}
        public object Add(params int[] numbers)
        {
            //var result = 0;
            //foreach (var item in numbers)
            //{
            //    result += item;
            //}
            //return result;

            return numbers.Sum(x => x);
        }

        internal object Mul(int number1, int number2)
        {
            return number1 * number2;
        }

        internal object Sub(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}