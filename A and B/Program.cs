using System;
using System.Reflection;

namespace A_and_B
{
    public class A
    {
        public A(B deriv1)
        {
            Console.WriteLine($"Class: {deriv1}");
            Console.WriteLine("Basic class: B");
            Console.WriteLine($"Properties: {deriv1.GetType().GetProperties()}");
            Console.WriteLine();
        }
            public A(B deriv1, B deriv2)
        {
            Console.WriteLine($"Class: {deriv1}");
            Console.WriteLine("Basic class: B");
            Console.WriteLine($"Properties: {deriv1.GetType().GetProperties()}");
            Console.WriteLine();

            Console.WriteLine($"Class: {deriv2}");
            Console.WriteLine("Basic class: B");
            Console.WriteLine($"Properties: {deriv2.GetType().GetProperties()}");
        }
        public A(B deriv1, B deriv2, B deriv3)
        {
            Console.WriteLine($"Class: {deriv1}");
            Console.WriteLine("Basic class: B");
            Console.WriteLine($"Properties: {deriv1.GetType().GetProperties()}");
            Console.WriteLine();

            Console.WriteLine($"Class: {deriv2}");
            Console.WriteLine("Basic class: B");
            Console.WriteLine($"Properties: {deriv2.GetType().GetProperties()}");
            Console.WriteLine();

            Console.WriteLine($"Class: {deriv3}");
            Console.WriteLine("Basic class: B");
            Console.WriteLine($"Properties: {deriv3.GetType().GetProperties()}");
        }
    }

    public abstract class B
    {
        public abstract double Math(double a, double b);
    }

    internal class DerivativeClass1 : B
    {
        public override double Math(double a, double b)
        {
            double s = a + b;
            Console.WriteLine($"Result = {s}");
            return s;
        }
    }

    internal class DerivativeClass2 : B
    {
        public override double Math(double a, double b)
        {
            double s = a - b;
            Console.WriteLine($"Result = {s}");
            return s;
        }
    }

    internal class DerivativeClass3 : B
    {
        public override double Math(double a, double b)
        {
            double s = a * b;
            Console.WriteLine($"Result = {s}");
            return s;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Addition;");
            Console.WriteLine("2.Subtraction;");
            Console.WriteLine("3.Multiplication.");
            Console.Write("Select an operation: ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first number: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double y = Convert.ToInt32(Console.ReadLine());

            DerivativeClass1 derivclass1 = new DerivativeClass1();
            DerivativeClass2 derivclass2 = new DerivativeClass2();
            DerivativeClass3 derivclass3 = new DerivativeClass3();

            switch (s)
            {
                case 1:

                    double m1 = derivclass1.Math(x, y);
                    break;

                case 2:

                    double m2 = derivclass2.Math(x, y);
                    break;

                case 3:
                    double m3 = derivclass3.Math(x, y);
                    break;

                default:
                    Console.WriteLine("Error.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Properties of which derived classes need to be displayed?");
            Console.Write("Select 1 or 1,2 or 1,2,3: ");
            string p = Console.ReadLine();
            Console.WriteLine();

            if (p == "1")
            {
                A a = new A(derivclass1);
            }

            else if (p == "1,2")
            {
                A a = new A(derivclass1, derivclass2);
            }

            else if (p == "1,2,3")
            {
                A a = new A(derivclass1, derivclass2, derivclass3);
            }

            else
            {
                Console.WriteLine("Error.");
            }     
        }
    }
}
