using System;

namespace Triangle

{
    public class Program
    {
        public static void Main()
        {
            Console.Write("n = ");
            int n = GetConsoleIntValue();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
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