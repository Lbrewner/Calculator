using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a math function you want calcuated i.e. 4 + 4.");
            string mathFunction = Console.ReadLine();

            PerformMath(mathFunction);
        }
        public static void PerformMath(string toBeCalculated)
        {
            char[] charOfOperator = { 'x', '*', '/', '\\', '+', '-' };
            int indexOfOperator = toBeCalculated.IndexOfAny(charOfOperator);
            decimal firstNumber;
            decimal secondNumber;

            if (indexOfOperator > 0 && indexOfOperator < toBeCalculated.Length - 1)
            {
                if (Decimal.TryParse(toBeCalculated.Substring(0, indexOfOperator), out firstNumber) && Decimal.TryParse(toBeCalculated.Substring(indexOfOperator + 1), out secondNumber))
                {
                    Console.WriteLine(MathFunctions(firstNumber, secondNumber, toBeCalculated));
                }
                else
                {
                    Console.WriteLine("Please enter a valid calcluation to perform.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid calculation to perform.");
            }
        } 
        public static decimal MathFunctions(decimal x, decimal y, string a)
        {
            if (a.Contains('x') || a.Contains('*'))
            {
                return x * y;
            }
            else if (a.Contains('/') || a.Contains('\\'))
            {
                return x / y;
            }
            else if (a.Contains('+'))
            {
                return x + y;
            }
            else
            {
                return x - y;
            }
        }

    }
}
