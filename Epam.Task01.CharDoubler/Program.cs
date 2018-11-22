using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01.CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Input second string:");
            string str2 = Console.ReadLine();

            string str3 = GetSingleSymbols(str2);
            Console.WriteLine($"Your result: {Environment.NewLine}{GetDoubleCharString(str1, str3)}");

        }

        private static string GetDoubleCharString(string str1, string str2)
        {
            if (str1 == null)
            {
                return str1;
            }
            var sb = new StringBuilder(str1.Length * 2);
            for (int i = 0; i < str1.Length; i++)
            {
                sb.Append(str1[i]);

                if (str2.IndexOf(char.ToLower(sb[sb.Length - 1])) >= 0)
                {
                    sb.Append(str1[i]);
                }
            }
            return sb.ToString();
        }

        public static string GetSingleSymbols(string str)
        {
            if (str == null)
            {
                return str;
            }

            str = str.ToLower();

            var sb = new StringBuilder(str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    if (str.IndexOf(str[i], i) == str.LastIndexOf(str[i]) && i != str.Length - 1)
                    {
                        sb.Append(str[i]);
                    }
                    else
                        if (i == str.Length - 1)
                    {
                        sb.Append(str[i]);
                    }
                }
            }
            return sb.ToString();
        }
    }
}
