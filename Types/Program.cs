using System;
using System.Diagnostics;

namespace Types
{
    public class Types
    {
        private int i;
        private string s;

        public Types(int I, string S)
        {
            this.i = I;
            this.s = S;
        }

        public void Method(int i, string s)
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

            Types types = new Types(a, b);
            types.Method(a, b);
        }
    }
}
