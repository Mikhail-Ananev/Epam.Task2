using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input positive integer:");

            bool result = Int32.TryParse(Console.ReadLine(), out int n);

            if (result && n > 0)
            {
                Draw(n);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public static void Draw(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
