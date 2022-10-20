using System;
using System.Diagnostics;

namespace Types
{
    public class Types
    {
        public virtual void Method(int i, string s)
        {
            Debug.WriteLine(i);
            Debug.WriteLine(s);

            Console.WriteLine($"Type: {i.GetType()}.");
            Console.WriteLine($"Value = {i}.");
            Console.WriteLine();

            Console.WriteLine($"Type: {s.GetType()}.");
            Console.WriteLine($"Value = {s}.");
            Console.ResetColor();
        }
    }

    public class Types2 : Types
    {
        public override void Method(int i, string s)
        {
            Debug.WriteLine(i);
            Debug.WriteLine(s);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Type: {i.GetType()}.");
            Console.WriteLine($"Value = {i}.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Type: {s.GetType()}.");
            Console.WriteLine($"Value = {s}.");
            Console.ResetColor();
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the word: ");
            string b = Console.ReadLine();
            Console.WriteLine();

            Types types = new Types();
            types.Method(a, b);
            Console.WriteLine();

            Console.Write("Enter a number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the word: ");
            string d = Console.ReadLine();
            Console.WriteLine();

            Types2 types2 = new Types2();
            types2.Method(c, d);
        }
    }
}
