using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                collection[i] = i+1;
            }

            DateTime current = DateTime.Now;

            foreach (int x in collection)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine($"{x} FizzBuzz");
                    //continue;
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine($"{x} Fizz");
                    //continue;
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine($"{x} Buzz");
                    //continue;
                }
            }

            Console.WriteLine(DateTime.Now - current);
        }
    }
}
