using System;

namespace Simple_Delegate
{
    class Program
    {
        public delegate int BinaryOp(int a, int b);

        static void Main(string[] args)
        {
            SimpleMath simpleMath = new();
            BinaryOp binaryOp = new(simpleMath.Add);
            binaryOp += simpleMath.Subtract;
            binaryOp -= simpleMath.Add;
            //binaryOp += simpleMath.SquareNumber;

            DisplayDelegateInfo(binaryOp);
            int result = binaryOp(100, 10);
            Console.WriteLine(result);
        }

        static void DisplayDelegateInfo(Delegate d)
        {
            foreach (Delegate item in d.GetInvocationList())
            {
                Console.WriteLine($"Method Name: {item.Method}");
                Console.WriteLine($"Type Name: {item.Target}");
            }
        }
    }
}
