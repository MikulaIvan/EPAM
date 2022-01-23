using System;

namespace ArrayProcessing
{
    public class Program
    {
        public static void Main()
        {
            int [] Array = new int [5];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Array[i] = r.Next(100);
                Console.WriteLine(Array[i]);
            }
            int min = Array[0], max = Array[0];
            for (int i = 0; i < 5; i++)
            {
                if (Array[i] > max) max = Array[i];
                if (Array[i] < min) min = Array[i];
            }
            Console.WriteLine("min = {0},max = {1}",min,max);
        }

    }
}