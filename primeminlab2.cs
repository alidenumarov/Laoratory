using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPrimeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fread = new FileStream(@"C:\Laboratories\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fwrite = new FileStream(@"C:\Laboratories\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamReader sr = new StreamReader(fread);
            StreamWriter sw = new StreamWriter(fwrite);

            string[] s = sr.ReadToEnd().Split('\n');
            int[] array = new int[s.Length];

            for (int i = 0; i < s.Length; ++i)
              array[i] = int.Parse(s[i]);

            int MIN = array[0];
            for (int i = 0; i < s.Length; ++i)
            {
                int p = array[i];
                bool prime = true;
                for (int j = 2; j * j <= p; ++j)
                    if (p % j == 0)
                        prime = false;
                if (prime == true && p != 1)
                {
                    if (p < MIN) MIN = p;
                }
            }
            sw.WriteLine(MIN);

            sr.Close();
            sw.Close();
        }
    }
}
