using System;
using System.Security.Cryptography;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            bool changed = false;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    changed = true;

                }

                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    changed = true;
                }

                if (!changed)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                changed = false;
            }
        }
    }
}
