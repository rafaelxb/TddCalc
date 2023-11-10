using TddCalc.Services;

namespace TddCalcTest
{
    public class CalculatorTests
    {
        private Calculator _calc;
        public CalculatorTests()
        {
            _calc = new Calculator();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        [InlineData(6, 7, 13)]
        public void TestSumMethod(int num1,int num2, int expectedResult)
        {
            var result = _calc.Sum(num1, num2);
            
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(4, 5, -1)]
        [InlineData(8, 2, 6)]
        public void TestMinusMethod(int num1, int num2, int expectedResult)
        {
            var result = _calc.Minus(num1, num2);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(8, 2, 16)]
        public void TestTimesMethod(int num1, int num2, int expectedResult)
        {
            var result = _calc.Times(num1, num2);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(6, 3, 2)]
        [InlineData(8, 2, 4)]
        public void TestDivideMethod(int num1, int num2, int expectedResult)
        {
            var result = _calc.Divide(num1, num2);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(4,0));
        }

        [Fact]
        public void TestLastThreeCalcs()
        {
            _calc.Sum(1,1);
            _calc.Sum(1, 1);
            _calc.Sum(1, 1);
            _calc.Sum(1, 1);

            var result = _calc.LastThreeCalcs();

            Assert.NotEmpty(result);

            Assert.Equal(3,result.Count);
        }
    }
}