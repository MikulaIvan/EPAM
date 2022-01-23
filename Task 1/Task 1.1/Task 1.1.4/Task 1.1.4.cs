using System;

namespace Tree

{
    public class Program
    {
        public static void Main()
        {
            Console.Write("n = ");
            int n = GetConsoleIntValue();
            for (int i=n-1;i>=0;i--) {
                for (int j = 1; j <= n-i; j++)
                {
                    for (int k = 0; k < n - j; k++)
                        Console.Write(" ");
                    for (int l = 1; l < j * 2; l++)
                        Console.Write("*");
                    Console.WriteLine();
                }
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