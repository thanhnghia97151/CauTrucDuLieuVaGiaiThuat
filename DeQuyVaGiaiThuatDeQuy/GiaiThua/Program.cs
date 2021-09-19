using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            
            Console.WriteLine(Giaithua(a));
            Console.ReadKey();
        }
        static long Giaithua(int a)
        {
            if (a==0)
            {
                return 1;
            }
            return a * Giaithua(a - 1);
        }
    }
}
