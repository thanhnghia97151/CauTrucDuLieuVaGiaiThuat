using System;

namespace HoanVi
{
    class Program
    {
        static int n;
        static int[] Ktra = new int[100];
        static int[] a = new int[100];
        static void Nhap()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < Ktra.Length; i++)
            {
                Ktra[i] = 0;
            }
            a[0] = 0;
        }
        static void Xuat()
        {
            for (int i = 1; i < n+1; i++)
            {
                Console.Write(a[i]);

            }
            Console.WriteLine();
        }
        static void HoanVi(int k)
        {
            for (int i = 1; i < n+1; i++)
            {
                if (Ktra[i]==0)
                {
                    a[k] = i;
                    Ktra[i] = 1;
                    if (k == n)
                    {
                        Xuat();
                    }
                    else
                        HoanVi(k + 1);
                    Ktra[i] = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            Nhap();
            HoanVi(1);
        }
    }
}
