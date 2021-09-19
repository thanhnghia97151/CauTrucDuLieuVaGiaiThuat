using System;

namespace Exam_Chon_K_Nguoi_Trong_N_Nguoi
{
    class Program
    {
        const int max = 100;
        static int n,k;
        static string[] ten = new string[100];
        static int[] a = new int[100];
        
        static void Nhap()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap k: ");
            k = int.Parse(Console.ReadLine());
            ten[0] = "";
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Nguoi thu  {i}: ");
                ten[i] = Console.ReadLine();
            }
            a[0] = 0;
        }
        static void Try(int j)
        {
            for (int i =a[j-1]+1 ; i <= n-k+j; i++)
            {
                a[j] = i;
                if (j == k)
                {
                    Xuat();
                }
                else
                    Try(j + 1);
            }
        }
        static void Xuat()
        {
            for (int i = 1; i < k+1; i++)
            {
                Console.Write(ten[a[i]]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Nhap();
            Try(1);
           
        }
    }
}
