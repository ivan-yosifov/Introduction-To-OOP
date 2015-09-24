/*In this chapter, you learned that although a double and a decimal  both hold fl oating-point numbers, a double can hold a larger value. Write a C# program that declares two variables—a double and a decimal . Experiment by assigning the same constant value to each variable so that the assignment to the double is legal but the assignment to the decimal is not. In other words, when you leave the decimal  assignment statement in the program, an error message should be generated that indicates the value is outside the range of the type decimal , but when you comment out the decimal  assignment, the program should compile correctly. 
 * Save the program as DoubleDecimalTest.cs.
 */
using System;

namespace DoubleDecimalTest
{
    class DoubleDecimalTest
    {
        static void Main(string[] args)
        {
            const double VALUE = Double.MaxValue;
            double doubleValue = VALUE;
            // decimal decimalValue = Convert.ToDecimal(VALUE);
        }
    }
}
