using System;

namespace MiniProject1
{
    class program
    {

        static int Fibonacci(int x){
            int one = 0;
            int second = 1;
            int i = 1;
            int left;
            int fiboToplam = 0;
            while(i <= x){
                left = one + second; //left = 1-2-3-5-8
                one = second; // one = 1-1-2-3-5
                second = left; // second = 1-2-3-5-8
                fiboToplam += one;
                i++;
            }
            Console.WriteLine("Toplam : "+ fiboToplam);
            return 0;
        }
        static void Main(string[] args)
        {
            int derinlik;
            Console.WriteLine("Lütfen Derinlik Giriniz:");
            derinlik = Convert.ToInt32(Console.ReadLine());
            Fibonacci(derinlik);
        }
    }
}