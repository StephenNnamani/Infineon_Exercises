﻿using Infineon_Exercises.Exercise_3a;

namespace Infineon_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise One Solution
            int[] checker = new int[100];

            for (int i = 1; i <= 100; i++)
            {
                int x = new Random().Next(1, 101);
                if (checker.Contains(x))
                {
                    i--;
                }
                else
                {
                    checker[i - 1] = x;
                    Console.WriteLine(x);
                    if (x % 7 == 0) Console.WriteLine("Lucky number!");
                    if (i % 5 == 0) Console.WriteLine("---");
                }
            }

            TestClass.TestMethod(checker);

            // Exercise 3A
            ClassA ParentClass = new ClassA();
            ClassC ThirdGenClass = new ClassC();
            ThirdGenClass.PrintMessage("I am Alive :)");
        }
    }
}