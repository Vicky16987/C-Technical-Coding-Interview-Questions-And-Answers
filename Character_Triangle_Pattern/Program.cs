using System;

namespace Character_Triangle_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 0;
            int length = 1;
            int space = 0;
            Console.WriteLine("Enter the number of Rows;");
            numberOfRows = Convert.ToInt32(Console.ReadLine());
            space = numberOfRows - 1;

            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                char ch = 'A';
                for (int l = 1; l <= length; l++)
                {
                    Console.Write(ch);
                    ch++;
                }
                space--;
                length = length + 2;

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
