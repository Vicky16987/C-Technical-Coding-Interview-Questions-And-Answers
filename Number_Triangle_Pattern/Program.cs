using System;

namespace Number_Triangle_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 0;
            int space = 0;
            int length = 1;
            Console.WriteLine("Enter Number of Rows: ");
            numberOfRows = Convert.ToInt32(Console.ReadLine());
            space = numberOfRows - 1;
            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int s = 1; s <= space; s++)
                {
                    Console.Write(" ");
                }
                for (int l = 1; l <= length; l++)
                {
                    Console.Write(l);
                }
                space--;
                length = length + 2;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
