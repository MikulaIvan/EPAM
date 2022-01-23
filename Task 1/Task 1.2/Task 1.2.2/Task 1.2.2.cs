using System;

namespace Doubler
{
    public class Program
    {
        static void Main()
        {
            string s1 = "написать программу, которая";
            string s2 = "описание";
            string s = "";
            int i, j;
            for (i = 0; i < s1.Length; i++)
            {
                for (j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        s += s1[i];
                        break;
                    }
                }
                s += s1[i];
            }
            Console.WriteLine(s);
            Console.ReadKey(true);
        }
    }
}