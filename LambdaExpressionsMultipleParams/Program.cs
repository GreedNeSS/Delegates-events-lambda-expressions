using System;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        public delegate string SimpleDelegate();
        static void Main(string[] args)
        {
            SimpleMath math = new();

            math.SetMathHandler((msg, result) =>
            {
                Console.WriteLine($"Message: {msg}, Result: {result}");
            });

            math.Add(10, 10);

            SimpleDelegate simpleDelegate = new SimpleDelegate(() => "Hello World");
            Console.WriteLine(simpleDelegate());
        }
    }
}
