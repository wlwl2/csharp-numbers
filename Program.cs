using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            // Range: -2,147,483,648 to 2,147,483,647
            // Size: Signed 32-bit integer
            // .NET Framework type: System.Int32
            int a = 2;
            int b = 3;
            int c = -1;
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(b / a);

            // Multiplication and division take precedence over
            // addition and subtraction.
            // You can force a different order of operation by adding
            // parentheses around the operation or operations you want
            // performed first.
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
        }

        static void WorkingWithDoubles()
        {
            // Approximate range: ±5.0 × 10^−324 to ±1.7 × 10^308
            // Precision: 15-16 digits
            // .NET Framework type: System.Double
            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e  + f) / g;
            // Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;

            // The number to the left of the E is the significand.
            // The number to the right is the exponent, as a power of 10.
            // Console.WriteLine($"The range of double is {min} to {max}");

            // Just like decimal numbers in math, doubles in C# can have
            // rounding errors.
            // 0.333333333333333 is not exactly the same as 1/3.
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        static void WorkingWithDecimals()
        {
            // Approximate Range:
            // (-7.9 x 10^28 to 7.9 x 10^28) / (10^0 to 10^28)
            // Precision: 28-29 significant digits
            // .NET Framework type: System.Decimal
            // The default value of a decimal is 0m.

            // Literals
            // If you want a numeric real literal to be treated as decimal,
            // use the suffix m or M, for example:
            // Without the suffix m, the number is treated as a double and
            // generates a compiler error.
            decimal myMoney = 300.5m;

            // Conversions
            // The integral types are implicitly converted to
            // decimal and the result evaluates to decimal. Therefore you can
            // initialize a decimal variable using an integer literal.
            decimal myMoney = 300;

            // There is no implicit conversion between other floating-point types and the
            // decimal type; therefore, a cast must be used to convert between these two types.
            // For example:
            decimal myMoney = 99.9m;
            double x = (double)myMoney;
            myMoney = (decimal)x;

            // Formatting Decimal Output

            /* Decimal and Double */
            // You can format the results by using the String.Format method, or
            // through the Console.Write method, which calls String.Format().
            // The currency format is specified by using the standard currency
            // format string "C" or "c," as shown in the second example later in
            // this article.
            decimal dec = 0m;
            double dub = 9;
            // The following line causes an error that reads "Operator '+' cannot be applied to
            // operands of type 'double' and 'decimal'"
            Console.WriteLine(dec + dub);
            // You can fix the error by using explicit casting of either operand.
            Console.WriteLine(dec + (decimal)dub);
            Console.WriteLine((double)dec + dub);

            /* Decimal and Int */
            // In this example, a decimal and an int are mixed in the same
            // expression. The result evaluates to the decimal type.
            public class TestDecimal
            {
                static void Main()
                {
                    decimal d = 9.1m;
                    int y = 3;
                    // Output: 12.1
                    Console.WriteLine(d + y);   // Result converted to decimal
                }
            }

            // In this example, the output is formatted by using the currency
            // format string. Notice that x is rounded because the decimal places
            // exceed $0.99. The variable y, which represents the maximum exact
            // digits, is displayed exactly in the correct format.
            public class TestDecimalFormat
            {
                static void Main()
                {
                    decimal x = 0.999m;
                    decimal y = 9999999999999999999999999999m;
                    Console.WriteLine("My amount = {0:C}", x);
                    Console.WriteLine("Your amount = {0:C}", y);
                }
            }
            /* Output:
                My amount = $1.00
                Your amount = $9,999,999,999,999,999,999,999,999,999.00
            */



            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
        }

        static void Main(string[] args)
        {
           // WorkingWithIntegers();
           // WorkingWithDoubles();
           WorkingWithDecimals();
        }
    }
}
