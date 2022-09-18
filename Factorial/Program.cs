using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = number; i > 0; i--)
            {
                fact = fact * i;
                if (i != 1)
                    Console.Write("{0} * ", i);
                else
                    Console.Write("{0} = {1}", i,fact);
            }
            //Console.Write(fact);
            Console.ReadLine();
        }
    }
}
