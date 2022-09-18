using System;

namespace Fibanacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1   
            for (int i = 2; i < number; i++)
            {
                int n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
