using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new("Lada", 100, 10);
            car.Info += Car_Info;
            car.AboutToBlow += Car_AboutToBlow;
            car.Exploded += Car_Exploded;

            for (int i = 0; i < 6; i++)
            {
                car.Accelerate(20);
            }

            car.Exploded -= Car_Exploded;

            for (int i = 0; i < 6; i++)
            {
                car.Accelerate(20);
            }
        }

        private static void Car_Info(string message)
        {
            ConsoleColor colorPrev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = colorPrev;
        }

        private static void Car_AboutToBlow(string message)
        {
            ConsoleColor colorPrev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = colorPrev;
        }

        private static void Car_Exploded(string message)
        {
            ConsoleColor colorPrev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = colorPrev;
        }
    }
}
