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
        [Fact]
        public void TestSumMethod()
        {
            Assert.Equal(6, _calc.Sum(4,2));
        }

        [Fact]
        public void TestMinusMethod()
        {
            Assert.Equal(2, _calc.Minus(4, 2));
        }

        [Fact]
        public void TestTimesMethod()
        {
            Assert.Equal(8, _calc.Times(4, 2));
        }

        [Fact]
        public void TestDivideMethod()
        {
            Assert.Equal(2, _calc.Divide(4, 2));
        }

        [Fact]
        public void TestDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(4,0));
        }

        [Fact]
        public void TestLastThreeCalcs()
        {
            Assert.NotEmpty(_calc.LastThreeCalcs());
        }
    }
}