using System;
using System.Collections.Generic;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");
            TraditionalDelegateSyntax();
            Console.WriteLine();

            AnonymousMethodSyntax();
            Console.WriteLine();

            LambdaExpressionSyntax();
            Console.WriteLine();

            AlternateLambdaExpressionSyntax();
            Console.WriteLine();
        }

        private static void TraditionalDelegateSyntax()
        {
            Console.WriteLine("\nTraditionalDelegateSyntax() => ");
            List<int> numbers = new List<int>();
            numbers.AddRange(new int[]{ 20, 1, 3, 4, 7, 44, 5, 9, 8 });

            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = numbers.FindAll(callback);

            Console.WriteLine("Here are your even numbers:");
            foreach (int num in evenNumbers)
            {
                Console.Write(num + "\t");
            }
        }

        private static bool IsEvenNumber(int num)
        {
            return (num % 2) == 0;
        }

        private static void AnonymousMethodSyntax()
        {
            Console.WriteLine("\nAnonymousMethodSyntax() => ");
            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] { 20, 1, 3, 4, 7, 44, 5, 9, 8 });

            List<int> evenNumbers = numbers.FindAll(delegate (int i) 
            {
                return (i % 2) == 0;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int num in evenNumbers)
            {
                Console.Write(num + "\t");
            }
        }

        private static void LambdaExpressionSyntax()
        {
            Console.WriteLine("\nLambdaExpressionSyntax() => ");
            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] { 20, 1, 3, 4, 7, 44, 5, 9, 8 });

            List<int> evenNumbers = numbers.FindAll(i => i % 2 == 0);

            Console.WriteLine("Here are your even numbers:");
            foreach (int num in evenNumbers)
            {
                Console.Write(num + "\t");
            }
        }

        private static void AlternateLambdaExpressionSyntax()
        {
            Console.WriteLine("\nAlternateLambdaExpressionSyntax() => ");
            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] { 20, 1, 3, 4, 7, 44, 5, 9, 8 });

            List<int> evenNumbers = numbers.FindAll((int i) =>
            {
                Console.WriteLine("=> " + i);
                return i % 2 == 0;
             });

            Console.WriteLine("Here are your even numbers:");
            foreach (int num in evenNumbers)
            {
                Console.Write(num + "\t");
            }
        }
    }
}
