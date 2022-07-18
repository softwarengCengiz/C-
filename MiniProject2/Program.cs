using System;

namespace MiniProject2
{
    class program
    {    

        static void DrawIt(int x){
            for(int i = 1; i <= x; i++){
                
                for(int j = 0; j <= i; j++){
                    Console.WriteLine(" ");
                }

                for (int k = 0; k < 2*i-1; k++)
                {
                    Console.Write("*");
                }
            }
        }
        static void Main(string[] args)
        {
            int boyut;
            Console.WriteLine("Lütfen Boyut Giriniz:");
            boyut = Convert.ToInt32(Console.ReadLine());

            DrawIt(boyut);
        }
    }
}