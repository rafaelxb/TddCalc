using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddCalc.Services
{
    public class Calculator
    {
        private List<string> _history;

        public Calculator()
        {
            _history = new List<string>();
        }

        public int Sum(int num1, int num2)
        {
            var result = num1 + num2;
            
            return result;
        }

        public int Minus(int num1, int num2)
        {
            var result = num1 - num2;

            return result;
        }

        public int Times(int num1, int num2)
        {
            var result = num1 * num2;

            return result;
        }

        public int Divide(int num1, int num2)
        {
            var result = num1 / num2;

            return result;
        }

        public List<string> LastThreeCalcs()
        {
            return new List<string>();
        }
    }
}
