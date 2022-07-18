using System;


namespace MiniProject5
{
    class Program
    {

        static void Mix(string str){
            for (int i = str.Length - 1; i >= 0; i--)
            {
                 Console.Write(str[i]);
            }
        }
        static void Main(string[] args)
        {
            string? words;
            Console.Write("Bir İfade Girin :");
            words = Console.ReadLine();

            Mix(words);
        }     
    }

}