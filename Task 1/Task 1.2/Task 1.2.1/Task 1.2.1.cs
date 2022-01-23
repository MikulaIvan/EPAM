using System;

namespace Averages
{
    public class Program
    {

        static void Main()
        {
            string str = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";
            char[] div = { ' ', ',', ':' };//Проверяю только встречающиеся в данной строке символы
            string[] result = str.Split(div);
            int len = result.Length;
            int sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Length == 0) len--;
                sum += result[i].Length;
            };
            Console.WriteLine((double)sum / (double)len);//Не округлял.
        }
    }
}