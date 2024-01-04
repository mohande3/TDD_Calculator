using FluentAssertions;

namespace TDD_Calculator.CustomCalculatorSystem
{
    public class CalculatorSysmteTest
    {
        //! 1+2 = 3
        //! Add(1,2) => 3
        //! ToString => (1+2) = 3
        
        //! Sub(1,2)=>-1
        //! ToString => (1-2) = -1

        [Fact]
        public void When_call_add_method_Expect_get_sum_of_numbers()
        {
            var _sut = new CalculatorSystem();

            var result = _sut.Add(1, 2);

            result.Should().Be(3);
        }

        [Fact]
        public void When_call_sub_method_Expect_get_sub_of_numbers()
        {
            var _sut = new CalculatorSystem();

            var result = _sut.Sub(1, 2);

            result.Should().Be(-1);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(10, 2, 12)]
        public void When_call_add_method_Expect_get_string_that_contains_operators_and_operand(int num1, int num2, int expectResult)
        {
            var _sut = new CalculatorSystem();

            var result = _sut.Add(num1, num2);

            _sut.ToString().Should().Be($"({num1}+{num2})={expectResult}");
        }


        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(10, 2, 8)]
        public void When_call_sub_method_Expect_get_string_that_contains_operators_and_operand(int num1, int num2, int expectResult)
        {
            var _sut = new CalculatorSystem();

            var result = _sut.Sub(num1, num2);

            _sut.ToString().Should().Be($"({num1}-{num2})={expectResult}");
        }

    }
}
