using System;

namespace Sender_and_EventArgs
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

        private static void Car_Info(object sender, CarEventArgs e)
        {
            ConsoleColor colorPrev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            if (sender is Car car)
            {
                Console.WriteLine($"Car name: {car.Petname}. Info: {e.msg}");
            }

            Console.ForegroundColor = colorPrev;
        }

        private static void Car_AboutToBlow(object sender, CarEventArgs e)
        {
            ConsoleColor colorPrev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (sender is Car car)
            {
                Console.WriteLine($"Car name: {car.Petname}. Warning: {e.msg}");
            }

            Console.ForegroundColor = colorPrev;
        }

        private static void Car_Exploded(object sender, CarEventArgs e)
        {
            ConsoleColor colorPrev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            if (sender is Car car)
            {
                Console.WriteLine($"Car name: {car.Petname}. Error: {e.msg}");
            }

            Console.ForegroundColor = colorPrev;
        }
    }
}
