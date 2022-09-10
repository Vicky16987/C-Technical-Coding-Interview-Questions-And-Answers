using System;
using System.Collections.Generic;

namespace count_the_occurrence_of_each_character_in_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Technical Interview Questions");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the Sentence to Count the Occurance:");

            string str = Console.ReadLine();

            Dictionary<char, int> characterCount = CountCharacterOccurrence.CountCharacter(str);

            foreach(var character in characterCount)
            {
                Console.WriteLine("Sentence Count Occurance is : {0} - {1}", character.Key,character.Value);
            }
            
            Console.ReadLine();
        }
    }

    public class CountCharacterOccurrence
    {
        public static Dictionary<char,int> CountCharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach(var character in str)
            {
                if(character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                        characterCount.Add(character, 1);
                    else
                        characterCount[character]++;

                }
                
            }

            return characterCount;
        }
    }
}
