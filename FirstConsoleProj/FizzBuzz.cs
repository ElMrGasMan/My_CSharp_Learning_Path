using System;
using System.Text;

namespace FirstConsoleProj
{
    class FizzBuzz
    {
        internal static void Divisible100Numbrs() 
        {
            for (int i = 0; i <= 100; i++)
            {
                StringBuilder builder = new StringBuilder(i + " is ");

                if (i % 3 == 0)
                {
                    builder.Append("Fizz");
                }
                if (i % 5 == 0)
                {
                    builder.Append("Buzz");
                }
                if (i % 7 == 0)
                {
                    builder.Append("Bazz");
                }

                Console.WriteLine(builder);
            }
        }
    }
}
