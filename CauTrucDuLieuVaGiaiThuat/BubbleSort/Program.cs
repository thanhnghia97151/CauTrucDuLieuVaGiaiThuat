using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 7, 6, 9, 9, 10, 16, 15, 14 };
            for (int i = 1; i < a.Length-1; i++)
            {
                for (int j = a.Length-1; j > i; j--)
                {
                    if (a[j]>a[j-1])
                    {
                        int tam;
                        tam = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = tam;
                    }
                }
            }
            Console.WriteLine("Mang: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }

    }
}
