using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            Console.WriteLine(Fibo(a));
            Console.ReadKey();
        }
        static long Fibo(int a)
        {
            if (a <=2)
            {
                return 1;
            }
            return Fibo(a - 1) + Fibo(a - 2);
        }
    }
}
