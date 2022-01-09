using System;

namespace SumOfNumbers
{
    public class Program
    {
        public static void Main()
        {
            int Sum = 0;
            for (int i = 1; i < 1000; i++)
                if ((i < 10) && ((i % 3 == 0) || (i % 5 == 0)))
                    Sum += i;
            Console.WriteLine(Sum);
        }

    }
}