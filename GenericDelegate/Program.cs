using System;

namespace GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T arg);

    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDelegate<string> strTarget = Stringtarget;
            MyGenericDelegate<int> intTarget = new (IntTarget);

            strTarget("Hello");
            IntTarget(20);
        }

        static void Stringtarget(string arg)
        {
            Console.WriteLine($"arg in UpperCase is: {arg.ToUpper()}");
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine($"++arg: {++arg}");
        }
    }
}
