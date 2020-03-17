﻿using System;

namespace CodeGym
{
    class Program
    {
        public static void Main()
        {
            int number1 = 1;
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
