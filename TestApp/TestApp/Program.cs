using System;

namespace TestApp
{
   public class Program
    {
        public static int Min(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }

       public static void Main(string[] args)
        {
            Console.WriteLine("Demo of Unit-testing in C#.");
            Console.ReadKey();
        }
    }
}
