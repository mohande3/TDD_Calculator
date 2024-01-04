using FluentAssertions;

namespace TDD_Calculator
{
    public class CalculatorTest
    {

        //todo Step1 : Weite Faild test
        //todo Step2 : Write some code for pass test
        //todo Step3 : Refactor

        //Add(1,2,3,4,5,6,7,.....)

        [Fact]
        public void Test_Add_Method()
        {
            var _sut = new Calculator();

            var result = _sut.Add(1, 2);

            result.Should().Be(3);
        }

        [Fact]
        public void Test_Add_multi_numners_Method()
        {
            var _sut = new Calculator();

            var result = _sut.Add(1, 2, 2, 3, 4);

            result.Should().Be(12);
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
