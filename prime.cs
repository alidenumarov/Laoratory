using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab121
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);

            int[] array = new int[n];
            for (int i = 0; i < n; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; ++i)
            {
                bool prime = true;
                for (int j = 2; j * j <= array[i]; ++j)
                    if (array[i] % j == 0)
                        prime = false;
                if (prime == true && array[i] != 1)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
