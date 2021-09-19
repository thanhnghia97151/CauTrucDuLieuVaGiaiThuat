using System;

namespace ChinhHopLapChapK
{
    class Program
    {
        static int n, k;
        static int[] a = new int[100];
        static void Nhap()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap k: ");
            k = int.Parse(Console.ReadLine());
        }
        static void Xuat()
        {
            for (int i = 1; i < k+1; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
        static void Try(int x)
        {
            for (int i = 1; i < n+1; i++)
            {
                a[x] = i;
                if (x == k)
                {
                    Xuat();
                }
                else
                    Try(x + 1);
            }
        }
        static void Main(string[] args)
        {
            Nhap();
            Try(1);
        }
    }
}
