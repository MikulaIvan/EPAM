using System;

namespace ArrayProcessing
{
    public class Program
    {
        public static void Main()
        {
            int[] Array = new int[5];
            
            for (int i = 0; i < 5; i++)
                Array[i] = GetConsoleIntValue();
            int sum = 0;
            for (int i = 0; i < 5; i++)
                if (Array[i] > 0) sum += Array[i];
            
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