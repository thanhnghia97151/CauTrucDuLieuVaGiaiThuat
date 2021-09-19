using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQuy_BaiToanGiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            long k = GiaiThua(n);
            Console.WriteLine(k);
            Console.ReadKey();
        }
       static long GiaiThua(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return n * GiaiThua(n-1);
        }
    }
}
