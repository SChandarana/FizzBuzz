﻿using System;
using System.Collections.Generic;
using System.Linq;

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
            
            for (int i = 1; i < 300; i++)
            {
                List<string> output = new List<string>();
                if (i % 3 == 0)
                {
                    output.Add("Fizz");

                }

                if (i % 5 == 0)
                {
                    output.Add("Buzz");
                }

                if (i % 7 == 0)
                {
                    output.Add("Bang");
                }

                if (i % 11 == 0)
                {
                    output.Clear();
                    output.Add("Bong");
                }

                if (i % 13 == 0)
                {
                    var firstB = output.FirstOrDefault(s => s.StartsWith("B"));
                    if (firstB == null)
                    {
                        output.Add("Fezz");
                    }
                    else
                    {
                        output.Insert(output.IndexOf(firstB), "Fezz");
                    }

                }


                if (i % 17 == 0)
                {
                    output.Reverse();
                }

                if (!output.Any())
                {
                    output.Add(i.ToString());
                }

                foreach (var word in output)
                {
                    Console.Write(word);
                }
                Console.WriteLine();

            }
        }
    }
}
