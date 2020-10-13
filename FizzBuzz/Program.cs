using System;

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
            
            for (int i = 1; i < 101; i++)
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

                if (string.IsNullOrEmpty(output))
                {
                    output += i;
                }
                Console.WriteLine(output);
                
            }
        }
    }
}
