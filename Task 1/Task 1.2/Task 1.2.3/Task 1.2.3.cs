using System;

namespace LowerCase
{
    public class Program
    {

        static void Main()
        {
            string str1 = "Антон выпил кофе и послушал Стинга";
            char[] div1 = { ' ' };
            string[] result1 = str1.Split(div1);
            int sum1 = 0;
            for (int i = 0; i < result1.Length; i++)
                if (result1[i] != "" && char.IsLower(result1[i][0]))
                    sum1++;
            Console.WriteLine("Вариант без * = {0}",sum1);
            string str2 = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";
            char[] div2 = { ' ', ',', ':' };
            string[] result2 = str2.Split(div2);
            int sum2 = 0;
            for (int i = 0; i < result2.Length; i++) 
                if (result2[i] != "" && char.IsLower(result2[i][0])) 
                    sum2++;
            Console.WriteLine("Вариант со * = {0}",sum2);
        }
    }
}