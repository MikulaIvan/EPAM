using System.Text;

namespace Validator
{
    public class Program
    {

        static void Main()
        {
            string str = "я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!";
            char[] div = { '.', '!', '?' };
            string[] result = str.Split(div, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder str1 = new StringBuilder();
            for (int i = 0; i < result.Length; ++i)
            {
                result[i] = result[i].Trim();
                StringBuilder str2 = new StringBuilder(result[i]);
                str2[0] = char.ToUpper(str2[0]);
                str1.Append(str2);
                str1.Append($"{str[str1.Length]} ");
            }
            Console.WriteLine(str1);
        }
    }
}