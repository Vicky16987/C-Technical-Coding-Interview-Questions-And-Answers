using System;

namespace Check_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Technical Interview Questions");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the word to check Palindrome:");

            string str = Console.ReadLine();

            string reverseString = ReverseString.reverse(str);

            if(reverseString == str)
            {
                Console.WriteLine("Reverse string is Palindrome : {0} ", reverseString);
            }
            else
            {
                Console.WriteLine("Reverse string is Not a Palindrome : {0} ", reverseString);
            }          
            Console.ReadLine();
        }

        public static class ReverseString
        {
            public static string reverse(string str)
            {
                string result = string.Empty;
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    result += str[i];
                }
                return result;

            }
        }
    }
}
