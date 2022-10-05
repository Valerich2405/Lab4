using System;

namespace ApplicationLicense
{
    public class ApplicationLicense
    {
        public void AllowCommon()
        {
            Console.WriteLine("---Free version---");
        }

        public void AllowTrial()
        {
            Console.WriteLine("---Trial version---");
        }

        public void AllowPro()
        {
            Console.WriteLine("---Pro version---");
        }
    }

    public class Check : ApplicationLicense
    {
        private int password;
        public Check(int Password)
        {
            this.password = Password;
        }  

        public void CheckApplication()
        {
            if(password == 12345)
            {
                AllowTrial();
            }

            else if(password == 123456789)
            {
                AllowPro();
            }

            else
            {
                AllowCommon();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your password: ");
            int password = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Check check = new Check(password);

            check.CheckApplication();
        }
    }
}
