using System;


namespace MiniProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double radius;
            double thickness = 0.2;
            ConsoleColor BorderColor = ConsoleColor.Yellow;
            Console.ForegroundColor = BorderColor;
            char symbol = '*';

            do
            {
                Console.Write("Enter Radius: ");
                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("Radius have to be positive number");
                }
            }
            while (radius <= 0);

            Console.WriteLine();
            double rIn = radius - thickness, r0ut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < r0ut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= r0ut * r0ut)
                    {
                        Console.Write(symbol);

                    }
                    else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }     
    }

}