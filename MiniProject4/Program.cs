using System;


namespace MiniProject4
{
    class Program
    {

        static void Fix(string? str, int x){
            char[] arrStr = str.ToCharArray();
            arrStr = arrStr.Where((source, index) => index != x).ToArray();         
            Console.WriteLine(arrStr);
        }

        static void Main(string[] args)
        {
            string? words;
            int index;

            Console.Write("Bir Kelime Girin :");
            words = Console.ReadLine();

            Console.Write("Bir Index Girin :");
            index = Convert.ToInt16(Console.ReadLine());

            Fix(words,index);
        }     
    }

}