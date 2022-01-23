using System;

namespace AnotherTriangle

{
    public class Program
    {
        public static void Main()
        {
            Console.Write("n = ");
            int n = GetConsoleIntValue();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n-i; j++)
                    Console.Write(" ");
                for (int k = 1; k < i*2; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        public static int GetConsoleIntValue()
        {
            string value = Console.ReadLine();
            int result = 0;
            if (Int32.TryParse(value, out result))
                return result;
            return 0;
        }
    }

}