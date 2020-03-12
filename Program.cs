using System;

namespace dotnet_using_divide_by_zero_exception
{
    class Program
    {
        public static void Main()
        {
            int number1 = 3000;
            int number2 = 0;
            try
            {
                int result = number1 / number2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
