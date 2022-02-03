using System;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new("Lada", 100, 10);

            car.Info += delegate (object sender, CarEventArgs e)
            {
                ConsoleColor colorPrev = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;

                if (sender is Car car)
                {
                    Console.WriteLine($"Car name: {car.Petname}. Info: {e.msg}");
                }

                Console.ForegroundColor = colorPrev;
            };

            car.AboutToBlow += delegate (object sender, CarEventArgs e)
            {
                ConsoleColor colorPrev = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (sender is Car car)
                {
                    Console.WriteLine($"Car name: {car.Petname}. Warning: {e.msg}");
                }

                Console.ForegroundColor = colorPrev;
            };

            car.Exploded += delegate (object sender, CarEventArgs e)
            {
                ConsoleColor colorPrev = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;

                if (sender is Car car)
                {
                    Console.WriteLine($"Car name: {car.Petname}. Error: {e.msg}");
                }

                Console.ForegroundColor = colorPrev;
            };

            for (int i = 0; i < 6; i++)
            {
                car.Accelerate(20);
            }

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                car.Accelerate(20);
            }
        }
    }
}
