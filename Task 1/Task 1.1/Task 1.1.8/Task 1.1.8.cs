using System;

namespace ArrayProcessing
{
    public class Program
    {
        public static void Main()
        {
            int[,,] Array = new int[1,2,3];
            for (int i = 0; i < 1; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 3; k++)
                        Array[i, j, k] = GetConsoleIntValue();
            for (int i = 0; i < 1; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 3; k++)
                        if (Array[i, j, k] > 0) Array[i, j, k] = 0;
            for (int i = 0; i < 1; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 3; k++)
                        Console.WriteLine(Array[i, j, k]);
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