using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new("Oka", 100, 10);
            car.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            car.RegisterWithCarEngine(OnCarEngineEvent2);

            for (int i = 0; i < 5; i++)
            {
                car.Accelerate(20);
            }

            car.UnRegisterWithCarEngine(OnCarEngineEvent2);

            car.Accelerate(10);
        }

        public static void OnCarEngineEvent(string message)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine($"=> {message}");
            Console.WriteLine("***********************************\n");
        }

        public static void OnCarEngineEvent2(string message)
        {
            Console.WriteLine("\n=> " + message.ToUpper() + "\n");
        }
    }
}
