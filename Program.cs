using System;

namespace mudarib3
{
    class Program
    {
        static void multiplier(int a)
        {
            if (a >= 3)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine(a);
                    multiplier(a - 3);
                }
                else
                    multiplier(a - 1);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("end");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            multiplier(n-1);
            Console.ReadKey();
        }
    }
}
