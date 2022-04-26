using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorClass : ICalcutator
    {
        int ICalcutator.Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        int ICalcutator.Minus(int number1, int number2)
        {
            return number1 - number2;
        }

        int ICalcutator.Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        int ICalcutator.Plus(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
