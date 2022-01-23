using System;

namespace FontAdjustment
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Параметры надписи: None\nВведите:\n1: bold\n2: italic\n3: underline");
            switch (GetConsoleIntValue())
            {
                case 1:
                    Console.WriteLine("Параметры надписи: Bold");
                    break;
                case 2:
                    Console.WriteLine("Параметры надписи: Italic");
                    break;
                case 3:
                    Console.WriteLine("Параметры надписи: Underline");
                    break;
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