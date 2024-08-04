using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Infineon_Exercises
{
    public static class TestClass
    {
        public static void TestMethod(int[] testArray)
        {
            Console.WriteLine("The next code runs in the TestClass to validate the output i.e to make sure no number is duplicated or listed twice\t");
            for (int i = 1; i<=testArray.Length; i++)
            {
                if (!testArray.Contains(i))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Test Failed Validation ---- there is a repeated number " + i);
                    Console.ResetColor();
                }
                if (i % 5 == 0) { Thread.Sleep(600);  Console.Write("- "); }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t \u2713 Test Validation Successful");
            Console.ResetColor();
        }
    }
}
