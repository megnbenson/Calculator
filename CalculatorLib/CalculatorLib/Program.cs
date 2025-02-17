﻿using System;

namespace CalculatorLib
{
    public class StaticCalculator
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            try
            {
                if (num2 == 0)
                {
                    throw new System.DivideByZeroException($"You cannot divide by {num2}");
                }
            }catch (Exception e)
            {
                return 0;
            }
            
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
