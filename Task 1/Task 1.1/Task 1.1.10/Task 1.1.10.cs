using System;

namespace ArrayProcessing
{
    public class Program
{
    public static void Main()
    {
        int[,] Array = new int[2, 3];
        int Sum = 0;
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 3; j++)
                Array[i, j] = GetConsoleIntValue();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write("{0} ", Array[i, j]);
            Console.WriteLine();
        }
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 3; j++)
                if ((i + j) % 2 == 0) Sum += Array[i, j];
        Console.WriteLine("Sum = {0}", Sum);
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