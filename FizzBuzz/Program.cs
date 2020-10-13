using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        /* Using a string to store output instead of write command so only one write is needed and no extra boolean var */
        static void Run()
        {
            
            for (int i = 1; i < 300; i++)
            {
                var output = "";
                if (i % 3 == 0)
                {
                    output += "Fizz";

                }

                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                if (i % 7 == 0)
                {
                    output += "Bang";
                }

                if (i % 11 == 0)
                {
                    output = "Bong";
                }

                if (i % 13 == 0)
                {
                    var firstB = output.IndexOf("B");
                    if (firstB == -1)
                    {
                        output += "Fezz";
                    }
                    else
                    {
                        output = output.Insert(firstB, "Fezz");
                    }

                }

                /* Splits output string into words of length 4 then reverses the order. Only works as all words Fizz, Fezz etc are of length 4.
                 Would likely need to use a List instead of string for var output and change the way Fezz placement is calculated if wanting to allow for words of any length
                 
                 */
                if (i % 17 == 0)
                {
                    var words = output.Length / 4;
                    List<string> wordList = new List<string>();
                    for (int j = 0; j < words; j++)
                    {
                        wordList.Add(output.Substring(j * 4, 4));
                        
                    }
                    wordList.Reverse();
                    output = "";
                    foreach (var word in wordList)
                    {
                        output += word;
                    }
                }

                if (string.IsNullOrEmpty(output))
                {
                    output += i;
                }

                Console.WriteLine(output);

            }
        }
    }
}
