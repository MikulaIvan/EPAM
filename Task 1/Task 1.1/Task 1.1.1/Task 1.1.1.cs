using System;

namespace Rectange
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("a = ");
            int a = GetConsoleIntValue();
            Console.Write("b = ");
            int b = GetConsoleIntValue();
            if (a <= 0 || b <= 0)
                Console.WriteLine("Incorrect input!");
            else
            {
                int S = a * b;
                Console.WriteLine("S = {0}", S);
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