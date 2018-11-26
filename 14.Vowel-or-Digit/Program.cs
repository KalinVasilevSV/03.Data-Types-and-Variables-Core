using System;

namespace _14.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            string vowels = "euioa";
            string digits = "0123456789";

            bool isVowel = false;
            bool isDigit = false;

            for (int i = 0; i < digits.Length; i++)
            {
                isDigit = (digits[i] == symbol);
                if (isDigit) break;
            }

            if(!isDigit)
            {
                for (int i = 0; i < vowels.Length; i++)
                {
                    isVowel = (vowels[i] == symbol);
                    if (isVowel) break;
                }
            }

            if (isVowel) Console.WriteLine("vowel");
            else if (isDigit) Console.WriteLine("digit");
            else Console.WriteLine("other");

        }
    }
}
