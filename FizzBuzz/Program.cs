﻿// Assignment 1 - C# Basics
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {

                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.Write("Fizz/Buzz,");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Fizz,");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Buzz,");
                }
                else
                {
                    Console.Write(i + ",");

                }

            }
        }

    }
}

