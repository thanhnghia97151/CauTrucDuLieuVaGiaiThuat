using System;

namespace DayNhiPhanDoDaiN
{
    class Program
    {
        static int[] a = new int[100];
        static int n;
        static void Nhap()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        static void Xuat()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]);


            }
            Console.WriteLine();
        }
        static void Tim(int k)
        {
            for (int i = 0; i <= 1; i++)
            {
                a[k] = i;
                if (k == n - 1)
                {
                    Xuat();
                }
                else Tim(k+1);
            }
        }
        static void Main(string[] args)
        {
            Nhap();
            Tim(0);
        }
    }
}
