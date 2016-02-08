using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Complex // создаем класс Complex
    {
        public int a, b;

        public Complex(int x, int y)
        {
            this.a = x;
            this.b = y;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex sum = new Complex((c1.a + c2.a), (c1.b + c2.b));
            return sum;
        }

        public override string ToString()
        {
             return this.a + " " + this.b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex(4, 2);
            Complex num2 = new Complex(5, 1);

            Console.WriteLine(num1 + num2);
            Console.ReadKey();
        }
    }
}
