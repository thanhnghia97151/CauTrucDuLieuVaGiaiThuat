using System;

namespace LietKeCacTapConK_PhanTu
{
    class Program
    {
        static int[] a = new int[100];
        static int n,k;
        
        static void Nhap()
        {
            Console.Write("Nhap n: "); n = int.Parse(Console.ReadLine());
            Console.Write("Nhap k: "); k = int.Parse(Console.ReadLine());
        }
        static void Xuat()
        {
            for (int i = 1; i <= k; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
        static void Tim(int i)
        {
            for (int j = a[i-1]+1; j <= n-k+i; j++)
            {
                a[i] = j;
                if (i == k)
                {
                    Xuat();
                }
                else Tim(i + 1);
            }
            
        }
        static void Main(string[] args)
        {
            a[0] = 0;
            Nhap();
            Tim(1);
        }
    }
}
