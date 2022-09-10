using System;

namespace reverse_each__word__in__a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Technical Interview Questions");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the Sentence to Reverse:");

            string str = Console.ReadLine();

            string reverseString = ReverseWord.reverse(str);

            Console.WriteLine("Reverse Sentence is : {0}", reverseString);
            Console.ReadLine();
        }
    }

    public static class ReverseWord
    {
        public static string reverse(string str)
        {
            string result = "";
            string finalResult = "";
            var stringArray = str.Split(" ");

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                if (result == "")
                    result += stringArray[i];
                else
                    result += " " + stringArray[i];
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                finalResult += result[i];
            }
            return finalResult;
        }
    }
}
