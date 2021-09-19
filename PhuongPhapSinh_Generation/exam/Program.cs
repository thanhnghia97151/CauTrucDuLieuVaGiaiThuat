using System;

namespace exam
{
    class Program
    {
        static void TangGiaTri(ref int b)
        {
            //b = 10;
            b = b + 1;
            //b=11 ---> a
            

        }
        static void Main(string[] args)
        {
            int a = 10;
            TangGiaTri(ref a);
            //a =b= 11

            Console.Write(a);

        }
    }
}
