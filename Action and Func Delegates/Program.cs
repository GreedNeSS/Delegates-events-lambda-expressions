using System;

namespace Action_and_Func_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, ConsoleColor, int> actionTarget = MessagePrint;
            Func<int, int, int> funcTarget1 = Add;
            Func<string, string, string> funcTarget2 = SumToString;

            actionTarget("Boom", ConsoleColor.Red, 5);
            Console.WriteLine(funcTarget1(100, 10));
            Console.WriteLine(funcTarget2("Hello", " World"));
        }

         static void MessagePrint(string msg, ConsoleColor color, int count)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = color;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = previous;
        }

        static int Add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        static string SumToString(string arg1, string arg2)
        {
            return arg1 + arg2;
        }
    }
}
