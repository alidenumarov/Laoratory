using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lab2MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream readMinMax = new FileStream(@"C:\Laboratories\MinMax.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(readMinMax);
            string[] s = reader.ReadToEnd().Split(' ');
            int[] array = new int[s.Length];
            for (int i = 0; i < s.Length; ++i)
          
                array[i] = int.Parse(s[i]);
                int min = array[0];
                for (int i = 1; i < s.Length; ++i)
                {
                    if (array[i] < min) 
                    {
                        min = array[i];
                    }
                }
            int max=array[1]; 
                for (int i = 0; i < s.Length; ++i)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }

                    Console.WriteLine(min);
                    Console.WriteLine(max);
                reader.Close();
                Console.ReadKey();
        }
    }
}
