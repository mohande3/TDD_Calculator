using FluentAssertions;

namespace TDD_Calculator
{
    public class CalculatorTest
    {

        //todo Step1 : Weite Faild test
        //todo Step2 : Write some code for pass test
        //todo Step3 : Refactor

        [Fact]
        public void Test_Add_Method()
        {
            var _sut = new Calculator();

            var result = _sut.Add(1, 2);

            result.Should().Be(3);
        }


        [Fact]
        public void Test_Sub_Method()
        {
            var _sut = new Calculator();

            var result = _sut.Sub(1, 2);

            result.Should().Be(-1);
        }

        [Fact]
        public void Test_Mul_Method()
        {
            var _sut = new Calculator();

            var result = _sut.Mul(1, 2);

            result.Should().Be(2);
        }
    }
}
