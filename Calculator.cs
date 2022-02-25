using System;

namespace TylerEagarCalcProj
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Sub()
        {
            return FirstNumber - SecondNumber;
        }

        public int Mult()
        {
            return FirstNumber * SecondNumber;
        }

        public static int operator +(Calculator calc, int number)
        {
            calc.FirstNumber += number;
            return calc.FirstNumber;
        }

        public static int operator -(Calculator calc, int number)
        {
            calc.FirstNumber -= number;
            return calc.FirstNumber;
        }

        public static int operator /(Calculator calc, int number)
        {
            calc.FirstNumber /= number;
            return calc.FirstNumber;
        }

        public static int operator %(Calculator calc, int number)
        {
            calc.FirstNumber %= number;
            return calc.FirstNumber;
        }
    }
}
