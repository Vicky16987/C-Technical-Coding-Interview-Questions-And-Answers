using System;

namespace Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Technical Interview Questions");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the word to Reverse:");

            string str = Console.ReadLine();

            string reverseString = ReverseString.reverse(str);

            Console.WriteLine("Reverse string is : {0}",reverseString);
            Console.ReadLine();

        }
    }

    public static class ReverseString
    {
        public static string reverse(string str)
        {
            string result = string.Empty;
            for(int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}
